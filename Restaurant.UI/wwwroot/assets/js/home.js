//Owl-carousel(start)
var owl = $(".owl-carousel");

$(document).ready(function () {
  owl.owlCarousel({
    items: 1,
    loop: true,
    autoplay: true,
    animateOut: "fadeOut",
    autoplayTimeout: 6000,
    autoplayHoverPause: false
  });
});
//Owl-carousel(end)

//Navbar-start
window.onscroll = function () {
  myFunction(),activeLink(),myUpperFunction();
};
//Navbar-fixed
var navbar2 = document.getElementById("nav2");
var sticky = navbar2.offsetTop;

function myFunction() {
  if (window.pageYOffset > sticky ) {
    navbar2.classList.add("sticky");
    navbar2.classList.add("background-scroll-navbar");
  } else {
    navbar2.classList.remove("sticky");
    navbar2.classList.remove("background-scroll-navbar");
    navbar2.classList.add("background-scroll-0-navbar");
  }
}

var specialName = document.querySelector(".special-ul").firstElementChild.firstElementChild;
specialName.classList.add("active-special");

var specialProperty = document.querySelector(".titleSpecials").nextElementSibling;
specialProperty.classList.remove("d-none");
specialProperty.classList.add("active-special-property");


// Specials Section (start)
var specialNames = document.querySelectorAll(".special-name");

[...specialNames].forEach((name) => {
  name.addEventListener("click", async function (ev) {

    ev.preventDefault();
    ChangeActiveSpecial(name);
    CurrentActiveProperty();
    GetClickData(name);

  });
});

function ChangeActiveSpecial(name) {
  let currentActiveSpecial = document.querySelector(".active-special");
  currentActiveSpecial.classList.remove("active-special");
  name.classList.add("active-special");
}

function CurrentActiveProperty() {
  let currentActiveSpecialProp = document.querySelector(".active-special-property");
  currentActiveSpecialProp.classList.remove("active-special-property");
  currentActiveSpecialProp.classList.add("d-none");
}

function GetClickData(name) {
  let clickNameDataId = name.getAttribute("data-id");
  let clickNameProp = document.getElementById(clickNameDataId);
  ChangeActiveProperty(clickNameProp);
}


function ChangeActiveProperty(clickNameProp){
  clickNameProp.classList.remove("d-none");
  clickNameProp.classList.add("active-special-property");
}
// Specials Section (end)