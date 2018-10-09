const express = require('express');
const https = require('https');
const port = 3000;

const app = express();

app.listen(port, () => {
	console.log("server is now running");
});

app.use("/*", (req, res, next) => {
	// Create a very long location
	var location  = 'something:\/\/action';
	location+= '\/';
	for (let i = location.length; i < 2084; i++) {
		location += "A";
	}
	console.log(location.length);
	res.setHeader('Location', location);
	res.status(302).send(`<body>Redirecting to <a href="${location}">${location}</a>.</body>`);
});