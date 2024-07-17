from langchain_core.tools import tool
from langchain.agents import create_tool_calling_agent
from langchain_openai import ChatOpenAI
from langchain import hub
from langchain.agents import AgentExecutor

llm = ChatOpenAI(model="llama3",
                 openai_api_base="http://localhost:8080/api/openai/v1",
                 openai_api_key="na")

# Get the prompt to use - you can modify this!
prompt = hub.pull("hwchase17/openai-functions-agent")

@tool
def get_current_weather(location: str, unit: str) -> object:
    """Get the current weather in a given location

    Args:
        location: The city and state, e.g. San Francisco, CA
        unit: The temperature unit to use. Infer this from the users location in celsius or fahrenheit
    """
    weather_info = {
        "location": location,
        "temperature": "78",
        "unit": unit,
        "forecast": ["sunny", "with a chance of meatballs"],
    }
    return weather_info


tools = [get_current_weather]
agent = create_tool_calling_agent(llm, tools, prompt)
agent_executor = AgentExecutor(agent=agent, tools=tools, verbose=True)

agent_executor.invoke({"input": "hwhat is the current weather in paris?"})
