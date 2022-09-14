const https = require('https');
const fs = require('fs');

const options = {
    hostname: 'localhost',
    port: 443,
    path: '/test',
    method: 'GET',
    rejectUnauthorized: false
};

const req = https.request(options, (res) => {
    console.log(`statusCode: ${res.statusCode}`)

    res.on('data', (d) => {
        process.stdout.write(d)
    })
})

