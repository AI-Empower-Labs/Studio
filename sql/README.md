This schema provides a solid foundation for demonstrating query generation with a large language model, covering a variety of common SQL operations like joins, filtering, and aggregation.

### SQL Schema

```sql
-- Table for storing user information
CREATE TABLE Users (
    user_id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Table for storing product information
CREATE TABLE Products (
    product_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(100) NOT NULL,
    description TEXT,
    price DECIMAL(10, 2) NOT NULL,
    stock INT NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Table for storing order information
CREATE TABLE Orders (
    order_id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT,
    total_amount DECIMAL(10, 2) NOT NULL,
    order_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
);

-- Table for storing order items
CREATE TABLE OrderItems (
    order_item_id INT PRIMARY KEY AUTO_INCREMENT,
    order_id INT,
    product_id INT,
    quantity INT NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (order_id) REFERENCES Orders(order_id),
    FOREIGN KEY (product_id) REFERENCES Products(product_id)
);

-- Table for storing product categories
CREATE TABLE Categories (
    category_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL
);

-- Table for linking products to categories
CREATE TABLE ProductCategories (
    product_id INT,
    category_id INT,
    PRIMARY KEY (product_id, category_id),
    FOREIGN KEY (product_id) REFERENCES Products(product_id),
    FOREIGN KEY (category_id) REFERENCES Categories(category_id)
);

-- Table for storing reviews
CREATE TABLE Reviews (
    review_id INT PRIMARY KEY AUTO_INCREMENT,
    product_id INT,
    user_id INT,
    rating INT NOT NULL CHECK (rating >= 1 AND rating <= 5),
    comment TEXT,
    review_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (product_id) REFERENCES Products(product_id),
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
);
```

### Explanation

1. **Users Table**: Stores user information including a unique identifier (`user_id`), username, email, password, and the date the user was created.
2. **Products Table**: Stores product information such as a unique identifier (`product_id`), name, description, price, stock quantity, and the date the product was added.
3. **Orders Table**: Stores order information, including a unique identifier (`order_id`), the ID of the user who made the order (`user_id`), the total amount of the order, and the date the order was made.
4. **OrderItems Table**: Stores information about individual items within an order, including a unique identifier (`order_item_id`), the ID of the order (`order_id`), the ID of the product (`product_id`), the quantity ordered, and the price at the time of the order.
5. **Categories Table**: Stores product categories, including a unique identifier (`category_id`) and the name of the category.
6. **ProductCategories Table**: Links products to categories using foreign keys referencing the `Products` and `Categories` tables.
7. **Reviews Table**: Stores product reviews, including a unique identifier (`review_id`), the ID of the product being reviewed (`product_id`), the ID of the user who wrote the review (`user_id`), the rating, the review comment, and the date the review was written.

Ingest to a local instance of AI Empower Labs via curl

```bash
curl -X 'POST' \
  'http://localhost:8080/api/semantic/ingest/file?documentId=README.md&index=sql' \
  -H 'accept: application/json' \
  -H 'Content-Type: multipart/form-data' \
  -F 'file=@README.md'
```

or

```bash
POST http://localhost:8080/api/semantic/ingest/file?documentId=readme&index=sql
accept: application/json
Content-Type: multipart/form-data; boundary=WebAppBoundary

--WebAppBoundary
Content-Disposition: form-data; name="file"; filename="README.md"

<@ ./sql/README.md
--WebAppBoundary--
```

Sample query:
'''
generate sql query for getting products that are in stock
'''