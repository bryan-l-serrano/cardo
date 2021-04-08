

const app = require('express')();
const http = require('http').Server(app);
const io = require('socket.io')(http);


app.get('/', (req, res) =>{
	res.sendFile(__dirname + '/index.html');
});

http.listen(3000, () => {
	console.log('listening on *:3000');
});

io.on('connection', (socket) => {
	console.log('a user connected');
	socket.on('message',(val) => {
		io.emit('value', val);
	});
});




