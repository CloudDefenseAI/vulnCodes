var xml = require('libxmljs');
var fs = require('fs');
var sys = require('sys');
var app = require('express')();

app.get('/user_input', function(req, res) {
    var doc = xml.parseXmlString(req.query.user_input, {noent: true});
    res.send(doc.toString());
})

app.listen(3000);
