# Miro

## [Miro](https://www.miro.com) API Clients in .NET and Python

```
\DOTNET
    \API-DOTNET
        \API-DOTNET <- .NET ( Core ) 6.0, based on OpenAPI Specification
        \API-DOTNET-Framework <- .NET Framework 4.8, based on OpenAPI Specification
\Python
    \API-Python <- Python, based on OpenAPI Specification
```

Please refer to the following Medium story tutorial:

[Create Miro API Clients in C# and Python from OpenAPI Specification](https://medium.com/@easylob/create-miro-api-clients-in-c-and-python-from-openapi-specification-6cf2ae527cee)

## [Miro](https://www.miro.com) Web SDK App with C# and ASP.NET Core

```
\DOTNET
    \App-DOTNET
        \my-api <- Web SDK App with C# and ASP.NET Core
```

Please refer to the following Medium story tutorial:

[Miro Web SDK App with C# and ASP.NET Core](https://medium.com/@easylob/miro-web-sdk-app-with-c-and-asp-net-core-2e5d692894d7)

To run the application execute:

```
dotnet run
```

## [Miro](https://www.miro.com) Web SDK App with Python and Flask

```
\Python
    \App-Python <- Web SDK App with Python and Flask
```

Please refer to the following Medium story tutorial:

[Miro Web SDK App with Python and Flask](https://medium.com/@easylob/miro-app-with-python-and-flask-aaa1f408b403)

To get the application running you need to install the following:

```
pip install flask flask-cors
```

To run the application with Flask ( Port 3000 is the same as used in React App ) execute:

```
flask run --host=0.0.0.0 --port=3000
```

To run the application with Gunicorn, in a Production server with https certificates, execute:

```
pip install gunicorn

WINDOWS
gunicorn ^
  -certfile /etc/letsencrypt/live/domain.com/cert.pem ^
  -keyfile /etc/letsencrypt/live/domain.com/privkey.pem ^
  -b 0.0.0.0:3443 ^
  app:app

LINUX
gunicorn \
  -certfile /etc/letsencrypt/live/domain.com/cert.pem \
  -keyfile /etc/letsencrypt/live/domain.com/privkey.pem \
  -b 0.0.0.0:3443 \
  app:app
```
