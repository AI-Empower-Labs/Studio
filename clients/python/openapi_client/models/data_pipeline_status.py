# coding: utf-8

"""
    Studio - AI Empower Labs

    # Studio API Documentation  ## Introduction Welcome to Studio by AI Empower Labs API documentation! We are thrilled to offer developers around the world access to our cutting-edge artificial intelligence technology and semantic search. Our API is designed to empower your applications with state-of-the-art AI capabilities, including but not limited to natural language processing, audio transcription, embedding, and predictive analytics.  Our mission is to make AI technology accessible and easy to integrate, enabling you to enhance your applications, improve user experiences, and innovate in your field. Whether you're building complex systems, developing mobile apps, or creating web services, our API provides you with the tools you need to incorporate AI functionalities seamlessly.  Support and Feedback We are committed to providing exceptional support to our developer community. If you have any questions, encounter any issues, or have feedback on how we can improve our API, please don't hesitate to contact our support team @ support@AIEmpowerLabs.com.  Terms of Use Please review our terms of use and privacy policy before integrating our API into your application. By using our API, you agree to comply with these terms.

    The version of the OpenAPI document: v1
    Contact: support@aiempowerlabs.com
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


from __future__ import annotations
import pprint
import re  # noqa: F401
import json

from datetime import datetime
from pydantic import BaseModel, ConfigDict, StrictBool, StrictStr
from typing import Any, ClassVar, Dict, List, Optional
from typing import Optional, Set
from typing_extensions import Self

class DataPipelineStatus(BaseModel):
    """
    DataPipelineStatus
    """ # noqa: E501
    completed: Optional[StrictBool] = None
    failed: Optional[StrictBool] = None
    empty: Optional[StrictBool] = None
    index: Optional[StrictStr] = None
    document_id: Optional[StrictStr] = None
    tags: Optional[Dict[str, List[StrictStr]]] = None
    creation: Optional[datetime] = None
    last_update: Optional[datetime] = None
    steps: Optional[List[StrictStr]] = None
    remaining_steps: Optional[List[StrictStr]] = None
    completed_steps: Optional[List[StrictStr]] = None
    __properties: ClassVar[List[str]] = ["completed", "failed", "empty", "index", "document_id", "tags", "creation", "last_update", "steps", "remaining_steps", "completed_steps"]

    model_config = ConfigDict(
        populate_by_name=True,
        validate_assignment=True,
        protected_namespaces=(),
    )


    def to_str(self) -> str:
        """Returns the string representation of the model using alias"""
        return pprint.pformat(self.model_dump(by_alias=True))

    def to_json(self) -> str:
        """Returns the JSON representation of the model using alias"""
        # TODO: pydantic v2: use .model_dump_json(by_alias=True, exclude_unset=True) instead
        return json.dumps(self.to_dict())

    @classmethod
    def from_json(cls, json_str: str) -> Optional[Self]:
        """Create an instance of DataPipelineStatus from a JSON string"""
        return cls.from_dict(json.loads(json_str))

    def to_dict(self) -> Dict[str, Any]:
        """Return the dictionary representation of the model using alias.

        This has the following differences from calling pydantic's
        `self.model_dump(by_alias=True)`:

        * `None` is only added to the output dict for nullable fields that
          were set at model initialization. Other fields with value `None`
          are ignored.
        """
        excluded_fields: Set[str] = set([
        ])

        _dict = self.model_dump(
            by_alias=True,
            exclude=excluded_fields,
            exclude_none=True,
        )
        # set to None if index (nullable) is None
        # and model_fields_set contains the field
        if self.index is None and "index" in self.model_fields_set:
            _dict['index'] = None

        # set to None if document_id (nullable) is None
        # and model_fields_set contains the field
        if self.document_id is None and "document_id" in self.model_fields_set:
            _dict['document_id'] = None

        # set to None if tags (nullable) is None
        # and model_fields_set contains the field
        if self.tags is None and "tags" in self.model_fields_set:
            _dict['tags'] = None

        # set to None if steps (nullable) is None
        # and model_fields_set contains the field
        if self.steps is None and "steps" in self.model_fields_set:
            _dict['steps'] = None

        # set to None if remaining_steps (nullable) is None
        # and model_fields_set contains the field
        if self.remaining_steps is None and "remaining_steps" in self.model_fields_set:
            _dict['remaining_steps'] = None

        # set to None if completed_steps (nullable) is None
        # and model_fields_set contains the field
        if self.completed_steps is None and "completed_steps" in self.model_fields_set:
            _dict['completed_steps'] = None

        return _dict

    @classmethod
    def from_dict(cls, obj: Optional[Dict[str, Any]]) -> Optional[Self]:
        """Create an instance of DataPipelineStatus from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "completed": obj.get("completed"),
            "failed": obj.get("failed"),
            "empty": obj.get("empty"),
            "index": obj.get("index"),
            "document_id": obj.get("document_id"),
            "tags": obj.get("tags"),
            "creation": obj.get("creation"),
            "last_update": obj.get("last_update"),
            "steps": obj.get("steps"),
            "remaining_steps": obj.get("remaining_steps"),
            "completed_steps": obj.get("completed_steps")
        })
        return _obj

