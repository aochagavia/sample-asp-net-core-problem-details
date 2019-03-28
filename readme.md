This repository showcases ASP.NET Core returning errors following the *Problem Description* format
described in [RFC 7807](https://tools.ietf.org/html/rfc7807). The only thing needed is a small
amount of configuration in `Startup.cs`.

You can try it out by POSTing an empty json object to `api/persons`. You should get a HTTP 400
response with the following body:

```js
{
    "errors": {
        "Age": [
            "The field Age must be between 18 and 99."
        ],
        "Name": [
            "The Name field is required."
        ]
    },
    "type": "https://asp.net/core",
    "title": "One or more validation errors occurred.",
    "status": 400,
    "detail": "Please refer to the errors property for additional details.",
    "instance": "/api/persons"
}
```
