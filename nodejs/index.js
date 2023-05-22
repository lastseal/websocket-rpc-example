

const WebSocket = require("ws");

const wss = new WebSocket.Server({port:8081}, ()=>{
    console.log("Server started");
});

wss.on('connection', (ws) => {
    console.log("connected....");
    ws.on('message', (data) => {
        console.log("data received "+data);
    });
});

wss.on('listening', ()=> {
    console.log("server is listening on port 8081");
});
