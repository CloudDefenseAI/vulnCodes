var express = require('express');
var app = express();

app.get('/save-profile', function(req, res) {
    const name = req.query.name;
    const age = req.query.age;
    const email = req.query.email;
    const phone = req.query.phone;
    const address = req.query.address;
    const city = req.query.city;
    
    res.send(`Name: ${name} Age: ${age} Email: ${email} Phone: ${phone} Address: ${address} City: ${city}`);
});
