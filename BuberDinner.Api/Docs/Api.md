# Buber Dinener API

- [Buber Dinner API](#buber-dinner-api)
	- [Auth](#auth)
		- [Register](#register)
			-[Register Request](#register-request)
			-[Register Response](#register-response)
		- [Login](#login)
			- [Login Request](#login-request)
			- [Login Response](#login-response)

## Auth

### Register

``` js
POST {{host}}/auth/register
```

#### Register Request

```json
{
	"firstName" : "Amichai",
	"lastName" : "Mantiband",
	"email" : "amichai@mantiband.com"
	"password" : "Amiko1234!"
}
```

#### Register Response

```js
200 OK
```

```json
{
	"id" : "b88fb253-1d95-4b03-8cb8-259e956f28c7",

}
```



