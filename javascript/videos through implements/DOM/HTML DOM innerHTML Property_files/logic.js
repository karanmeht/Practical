
var creative = {};
var car = {};
/**
* Window onload handler.
*/
function preInit() {
    setupDom();

    if (Enabler.isInitialized()) {
        init();
    } else {
        Enabler.addEventListener(
            studio.events.StudioEvent.INIT,
            init
        );
    }
}

/**
* Select ad elements with zepto selectors to setup dom
*/
function setupDom() {
    creative.dom = {};
    creative.dom.mainContainer = document.getElementById('main-container');
    creative.dom.exit = document.getElementById('exit');

    creative.dom.tablet = $('#tablet');
    creative.dom.tabletHolder = $('#tablet-holder');
    creative.dom.tabletFinger = $('#tablet-finger');
    creative.dom.gphx = $('#gphx');
    creative.dom.taxi = $('#taxi');
    creative.dom.city= $('#bg-city');

    // creative.dom.copy1 = $('#copy1');
    creative.dom.copy1F = $('#copy1-f');
    creative.dom.copy1O = $('#copy1-o');
    creative.dom.copy1R = $('#copy1-r');

    creative.dom.copy2 = $('#copy2');
    creative.dom.copy2a1 = $('#copy2-1');
    creative.dom.copy2a2 = $('#copy2-2');
    creative.dom.copy2a3 = $('#copy2-3');
    creative.dom.copy2a4 = $('#copy2-4');
    creative.dom.copy2a5 = $('#copy2-5');
    creative.dom.copy2a6 = $('#copy2-6');
    creative.dom.copy2a7 = $('#copy2-7');
    creative.dom.copy2a8 = $('#copy2-8');
    creative.dom.copy2a9 = $('#copy2-9');
    creative.dom.copy2a10 = $('#copy2-10');
    creative.dom.copy2a11 = $('#copy2-11');
    creative.dom.copy2a12 = $('#copy2-12');
    creative.dom.copy2a13 = $('#copy2-13');
    creative.dom.copy2a14 = $('#copy2-14');
    creative.dom.copy2a15 = $('#copy2-15');
    creative.dom.copy2a16 = $('#copy2-16');
    creative.dom.copy2a17 = $('#copy2-17');
    creative.dom.copy2a18 = $('#copy2-18');
    creative.dom.copy2a19 = $('#copy2-19');
    creative.dom.copy2a20 = $('#copy2-20');
    creative.dom.copy2a21 = $('#copy2-21');
    creative.dom.copy2a22 = $('#copy2-22');
    creative.dom.copy2a23 = $('#copy2-23');


    creative.dom.copy3 = $('#copy3');

    creative.dom.dotdotdot = $('#dotdotdot');
    creative.dom.dot1 = $('#dot1');
    creative.dom.dot2 = $('#dot2');
    creative.dom.dot3 = $('#dot3');

    creative.dom.logo = $('#logo');
    creative.dom.cta = $('#cta');

    creative.dom.footer = $('#footer');

    creative.dom.startNowButtonShimmer = $('.icon-effect');

}

/**
* Ad initialisation.
*/
function init() {

    addListeners();

    // Polite loading
    if (Enabler.isVisible()) {
        show();
    }
    else {
        Enabler.addEventListener(studio.events.StudioEvent.VISIBLE, show);
    }
}

/**
* Adds appropriate listeners at initialization time
*/
function addListeners() {
    creative.dom.exit.addEventListener('click', exitClickHandler);
}

/**
*  Shows the ad.
*/
function show() {
    creative.dom.exit.style.display = "block";
    //run the animations

    runAnimationLoop();
    tabletLoop();
    ellipsis();
}


function tabletLoop(){
    creative.tabletTimeline = new TimelineLite({
        onComplete:repeatTablet
    });

    creative.tabletTimeline

    .addLabel('tab-frame-1')
    .to(creative.dom.tablet, 0.15, {top:-2,  delay:0}, 'tab-frame-1')
    .to(creative.dom.tablet, 0.15, {top:0, delay:0.15}, 'tab-frame-1')
    .to(creative.dom.tablet, 0.15, {top:-1,  delay:0.3}, 'tab-frame-1')
    .to(creative.dom.tablet, 0.15, {top:1,  delay:0.45}, 'tab-frame-1')
    .to(creative.dom.tablet, 0.15, {top:3,  delay:0.6}, 'tab-frame-1')
    .to(creative.dom.tablet, 0.15, {top:-1,  delay:0.75}, 'tab-frame-1')
    .to(creative.dom.tablet, 0.15, {top:0,  delay:0.9}, 'tab-frame-1')

    function repeatTablet(){
        creative.tabletTimeline.restart();
    }

}



function ellipsis(){
    creative.dotsTimeline = new TimelineLite({
        onComplete:repeatDots
    });

    creative.dotsTimeline

    .addLabel('dot-frame-1')
    .to(creative.dom.dot1, 0.25, {autoAlpha:0, ease:Back.easeIn, delay:0}, 'dot-frame-1')
    .to(creative.dom.dot1, 0.25, { autoAlpha:1, ease:Back.easeOut, delay:0.25}, 'dot-frame-1')
    .to(creative.dom.dot2, 0.25, { autoAlpha:0, ease:Back.easeIn, delay:0.125}, 'dot-frame-1')
    .to(creative.dom.dot2, 0.25, { autoAlpha:1, ease:Back.easeOut, delay:0.5}, 'dot-frame-1')
    .to(creative.dom.dot3, 0.25, { autoAlpha:0, ease:Back.easeIn, delay:0.25}, 'dot-frame-1')
    .to(creative.dom.dot3, 0.25, { autoAlpha:1, ease:Back.easeOut, delay:0.75}, 'dot-frame-1')



    function repeatDots(){
        creative.dotsTimeline.restart();
    }

}





function runAnimationLoop(){
    creative.MainTimeline = new TimelineLite({
       onComplete:repeatMainTimeline
    });

    creative.MainTimeline

    .addLabel('frame-1')
    .to(creative.dom.logo, 0.5, {autoAlpha:0, delay:1}, 'frame-1')
    .to(creative.dom.footer, 0.5, {bottom:0,ease:Circ.easeOut, delay:1.5}, 'frame-1')

    .to(creative.dom.tabletHolder, 0.5, {top:50 ,ease:Circ.easeOut, delay:2}, 'frame-1')
    .to(creative.dom.tabletFinger, 0.5, {top:50 ,ease:Circ.easeInOut, delay:3}, 'frame-1')
    .to(creative.dom.gphx, 1, {top:-67 ,ease:Circ.easeOut, delay:3.25}, 'frame-1')


    .to(creative.dom.copy2, 0.5, {autoAlpha:1, delay:4}, 'frame-1')
    .to(creative.dom.copy1F, 0.1, {autoAlpha: 1, ease: Circ.easeOut, delay: 4.2}, 'frame-1')
    .to(creative.dom.copy2, 0.1, {left:140, delay:4.3}, 'frame-1')
    .to(creative.dom.copy1O, 0.1, {autoAlpha: 1, ease: Circ.easeOut, delay: 4.3}, 'frame-1')
    .to(creative.dom.copy2, 0.1, {left:136.7, delay:4.4}, 'frame-1')
    .to(creative.dom.copy1R, 0.1, {autoAlpha: 1, ease: Circ.easeOut, delay: 4.4}, 'frame-1')

    .to(creative.dom.dotdotdot, 0.5, {autoAlpha:1, delay:4.4}, 'frame-1')

    .addLabel('frame-2')

    .to(creative.dom.city, 6.75, {left:-1000, ease:Linear.easeNone, delay:0}, 'frame-2')

    .to(creative.dom.tabletHolder, 0.75, {autoAlpha:0, scale:0, top:180, left:150,  delay:1.5}, 'frame-2')
    .to(creative.dom.city, 0.75, {autoAlpha:1, delay:1.5}, 'frame-2')
    .to(creative.dom.taxi, 0.75, {autoAlpha:1, delay:1.5}, 'frame-2')


    .to(creative.dom.dotdotdot, 0.25, {autoAlpha:0, delay:2}, 'frame-2')

    .to(creative.dom.copy2, 1.15, {left:26, ease:Linear.easeNone, delay:2.1}, 'frame-2')

    .to(creative.dom.copy2a1, 0.05, {autoAlpha:1, delay:2.15}, 'frame-2')
    .to(creative.dom.copy2a2, 0.05, {autoAlpha:1, delay:2.2}, 'frame-2')
    .to(creative.dom.copy2a3, 0.05, {autoAlpha:1, delay:2.25}, 'frame-2')
    .to(creative.dom.copy2a4, 0.05, {autoAlpha:1, delay:2.3}, 'frame-2')
    .to(creative.dom.copy2a5, 0.05, {autoAlpha:1, delay:2.35}, 'frame-2')
    .to(creative.dom.copy2a6, 0.05, {autoAlpha:1, delay:2.4}, 'frame-2')
    .to(creative.dom.copy2a7, 0.05, {autoAlpha:1, delay:2.45}, 'frame-2')
    .to(creative.dom.copy2a8, 0.05, {autoAlpha:1, delay:2.5}, 'frame-2')
    .to(creative.dom.copy2a9, 0.05, {autoAlpha:1, delay:2.55}, 'frame-2')
    .to(creative.dom.copy2a10, 0.05, {autoAlpha:1, delay:2.6}, 'frame-2')
    .to(creative.dom.copy2a11, 0.05, {autoAlpha:1, delay:2.65}, 'frame-2')
    .to(creative.dom.copy2a12, 0.05, {autoAlpha:1, delay:2.7}, 'frame-2')
    .to(creative.dom.copy2a13, 0.05, {autoAlpha:1, delay:2.75}, 'frame-2')
    .to(creative.dom.copy2a14, 0.05, {autoAlpha:1, delay:2.8}, 'frame-2')
    .to(creative.dom.copy2a15, 0.05, {autoAlpha:1, delay:2.85}, 'frame-2')
    .to(creative.dom.copy2a16, 0.05, {autoAlpha:1, delay:2.9}, 'frame-2')
    .to(creative.dom.copy2a17, 0.05, {autoAlpha:1, delay:2.95}, 'frame-2')
    .to(creative.dom.copy2a18, 0.05, {autoAlpha:1, delay:3}, 'frame-2')
    .to(creative.dom.copy2a19, 0.05, {autoAlpha:1, delay:3.05}, 'frame-2')
    .to(creative.dom.copy2a20, 0.05, {autoAlpha:1, delay:3.1}, 'frame-2')
    .to(creative.dom.copy2a21, 0.05, {autoAlpha:1, delay:3.15}, 'frame-2')
    .to(creative.dom.copy2a22, 0.05, {autoAlpha:1, delay:3.2}, 'frame-2')
    .to(creative.dom.copy2a23, 0.05, {autoAlpha:1, delay:3.25}, 'frame-2')



    .to(creative.dom.taxi, 0.8, {left:300, ease:Back.easeIn, delay:6}, 'frame-2')
    .to(creative.dom.city, 0.5, {autoAlpha:0, delay:6.5}, 'frame-2')
    .to(creative.dom.copy2, 0.5, {autoAlpha:0, delay:6.5}, 'frame-2')
    .to(creative.dom.footer, 0.5, {autoAlpha:0, ease:Circ.easeIn, delay:6.5}, 'frame-2')

    .set(creative.dom.logo, {left:-100, top:-30, delay:0}, 'frame-2')
    .set(creative.dom.copy3, {left:-100, delay:0}, 'frame-2')


    .addLabel('frame-3')
    .to(creative.dom.logo, 0.5, {left:0, autoAlpha:1, ease:Circ.easeOut, delay:0}, 'frame-3')
    .to(creative.dom.copy3, 0.5, {left:0, autoAlpha:1, ease:Circ.easeOut, delay:0.5}, 'frame-3')
    .to(creative.dom.cta, 0.5, {scale:1, autoAlpha:1,  ease:Back.easeOut, delay:1}, 'frame-3')

    .addLabel('shimmer')
    .set(creative.dom.startNowButtonShimmer, {className: "+=shimmer"},'shimmer')
    .to(creative.dom.startNowButtonShimmer,0.6, {autoAlpha:0,delay:0.5},'shimmer')

    creative.playedOnce = false;
    function repeatMainTimeline(){
        if (creative.playedOnce == false) {
            creative.playedOnce = true;
            setTimeout(function(){
                creative.MainTimeline.restart();
            },3000)
        } else {
            //donothing
        }
    }

}



// ---------------------------------------------------------------------------------
// MAIN
// ---------------------------------------------------------------------------------

function exitClickHandler() {
    Enabler.exit('BackgroundExit');
}

/**
*  Main onload handler
*/
window.addEventListener('load', preInit);
