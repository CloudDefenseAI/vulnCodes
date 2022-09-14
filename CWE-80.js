var express = require('express');
var app = express();

const XssSanitizer = require('xss-sanitizer');

app.get('/save-profile', function(req, res) {
    const name = XssSanitizer.sanitize(req.query.name);
    const age = XssSanitizer.sanitize(req.query.age);
    const email = XssSanitizer.sanitize(req.query.email);
    const phone = XssSanitizer.sanitize(req.query.phone);
    const address = XssSanitizer.sanitize(req.query.address);
    const city = XssSanitizer.sanitize(req.query.city);

    res.send(`Name: ${name} Age: ${age} Email: ${email} Phone: ${phone} Address: ${address} City: ${city}`);
});

app.listen(3000, function() {
    console.log('App listening on port 3000!');
})
