// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// live clock
function updateClock() {
    var serverTimeElement = document.getElementById('serverTime');
    var currentTime = new Date();
    var hours = currentTime.getHours();
    var minutes = currentTime.getMinutes();
    var seconds = currentTime.getSeconds();

    // Add leading zeros to minutes and seconds if needed
    minutes = (minutes < 10 ? "0" : "") + minutes;
    seconds = (seconds < 10 ? "0" : "") + seconds;

    var formattedTime = hours + ":" + minutes + ":" + seconds;
    serverTimeElement.innerText = formattedTime;
}

// Update the clock every second (1000 milliseconds)
setInterval(updateClock, 1000);


// typewriter animation 
var i = 0;
var txt = '>>> What if I told you there are no servers...';
var speed = 70;

function typeWriter() {
    if (i < txt.length) {
        document.getElementById("msg").innerHTML += txt.charAt(i);
        i++;
        setTimeout(typeWriter, speed);
    }
}

typeWriter();
