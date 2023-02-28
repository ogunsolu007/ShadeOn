// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Add to cart button function
const cartBtn = document.querySelectorAll('.cart-button')

cartBtn.forEach(btn => {
    btn.addEventListener('click', () => {
        btn.classList.add("clicked");
    })
})





// Video controls script
const video = document.querySelector("#myvideo");
const play_pauseBtn = document.querySelector("#play");
const forwardBtn = document.querySelector("#forward");
const backwardBtn = document.querySelector("#backward");
const volumeSlider = document.querySelector(".input-range");
const mute_unmuteBtn = document.querySelector(".mute_unmute");
const progressBar = document.querySelector(".progress-bar");
const currentVidTime = document.querySelector(".current-time");
const VidDuration = document.querySelector(".video-duration");

//Play and Pause function
play_pauseBtn.addEventListener("click", () => {
    if (video.paused) {
        video.play();
        play_pauseBtn.classList.replace("fa-play", "fa-pause");
    } else {
        video.pause();
        play_pauseBtn.classList.replace("fa-pause", "fa-play");
    }
});

const formatTime = (time) => {
    let sec = Math.floor(time % 60);
    let min = Math.floor(time / 60) % 60;
    let hr = Math.floor(time / 3600);

    sec = sec < 10 ? `0${sec}` : sec;
    min = min < 10 ? `0${min}` : min;
    hr = hr < 10 ? `0${hr}` : hr;

    if (hr == 0) {
        return `${min}:${sec}`;
    }
    return `${hr}:${min}:${sec}`;
};

//Progress bar updating
video.addEventListener("timeupdate", (e) => {
    let { duration, currentTime } = e.target;
    let percent = (currentTime / duration) * 100;
    progressBar.style.width = `${percent}%`;
    currentVidTime.textContent = formatTime(currentTime);
});

//video duration
video.addEventListener("loadeddata", () => {
    VidDuration.textContent = formatTime(video.duration);
});

//forwarding
forwardBtn.addEventListener("click", () => {
    video.currentTime += 5;
});

//backwarding
backwardBtn.addEventListener("click", () => {
    video.currentTime -= 5;
});

//Mute and Unmute button
mute_unmuteBtn.addEventListener("click", () => {
    if (mute_unmuteBtn.classList.contains("fa-volume-high")) {
        video.volume = 0.0;
        mute_unmuteBtn.classList.replace("fa-volume-high", "fa-volume-off");
    } else {
        video.volume = 0.5;
        mute_unmuteBtn.classList.replace("fa-volume-off", "fa-volume-high");
    }
    volumeSlider.value = video.volume;
});

// Volume slider
volumeSlider.addEventListener("input", () => {
    video.volume = volumeSlider.value;
    if (volumeSlider.value == 0) {
        mute_unmuteBtn.classList.replace("fa-volume-high", "fa-volume-off");
    } else {
        mute_unmuteBtn.classList.replace("fa-volume-off", "fa-volume-high");
    }
});
/////////////////////////////////////////////////



///////////////////////////////////////
// Slider
var indicator = document.getElementsByClassName('indicator-btn')
var slide = document.getElementById('slide')

indicator[0].onclick = () => {
    slide.style.transform = 'translateX(0px)';
    for (i = 0; i < 3; i++) {
        indicator[i].classList.remove('active')
    }
    indicator[0].classList.add("active");
}
indicator[1].onclick = () => {
    slide.style.transform = 'translateX(-800px)';
    for (i = 0; i < 3; i++) {
        indicator[i].classList.remove('active')
    }
    indicator[1].classList.add("active");
}

indicator[2].onclick = () => {
    slide.style.transform = 'translateX(-1600px)';
    for (i = 0; i < 3; i++) {
        indicator[i].classList.remove('active')
    }
    indicator[2].classList.add("active");
}


let slideIndex = 0;
showSlides();

function showSlides() {
    let i;
    let slides = document.getElementsByClassName("slide-col");
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    slideIndex++;
    if (slideIndex > slides.length) { slideIndex = 1 }
    slides[slideIndex - 1].style.display = "block";

    for (i = 0; i < indicator.length; i++) {
        indicator[i].className = indicator[i].className.replace(" active", "");
    }

    indicator[slideIndex - 1].className += " active";


    setTimeout(showSlides, 2000); // Change image every 2 seconds
}

///////////////////////////////////////
///////////////////////////////////////
///////////////////////////////////////



//Admin dashboard tab
document.getElementByClassName("defaultOpen").click();

function openCity(evt, cityName) {
    // Declare all variables
    var i, tabcontent, tablinks;

    // Get all elements with class="tabcontent" and hide them
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }

    // Get all elements with class="tablinks" and remove the class "active"
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }

    // Show the current tab, and add an "active" class to the button that opened the tab
    document.getElementById(cityName).style.display = "block";
    evt.currentTarget.className += " active";
}


