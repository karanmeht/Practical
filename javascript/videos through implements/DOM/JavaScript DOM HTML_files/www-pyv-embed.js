(function(){var l=this;function m(a){return void 0!==a}
function p(a){a=a.split(".");for(var b=l,c;c=a.shift();)if(null!=b[c])b=b[c];else return null;return b}
function aa(){}
function ca(a){var b=typeof a;if("object"==b)if(a){if(a instanceof Array)return"array";if(a instanceof Object)return b;var c=Object.prototype.toString.call(a);if("[object Window]"==c)return"object";if("[object Array]"==c||"number"==typeof a.length&&"undefined"!=typeof a.splice&&"undefined"!=typeof a.propertyIsEnumerable&&!a.propertyIsEnumerable("splice"))return"array";if("[object Function]"==c||"undefined"!=typeof a.call&&"undefined"!=typeof a.propertyIsEnumerable&&!a.propertyIsEnumerable("call"))return"function"}else return"null";
else if("function"==b&&"undefined"==typeof a.call)return"object";return b}
function q(a){return"array"==ca(a)}
function r(a){return"string"==typeof a}
function t(a){return"function"==ca(a)}
function da(a){var b=typeof a;return"object"==b&&null!=a||"function"==b}
function ea(a,b,c){return a.call.apply(a.bind,arguments)}
function fa(a,b,c){if(!a)throw Error();if(2<arguments.length){var d=Array.prototype.slice.call(arguments,2);return function(){var c=Array.prototype.slice.call(arguments);Array.prototype.unshift.apply(c,d);return a.apply(b,c)}}return function(){return a.apply(b,arguments)}}
function ga(a,b,c){ga=Function.prototype.bind&&-1!=Function.prototype.bind.toString().indexOf("native code")?ea:fa;return ga.apply(null,arguments)}
function u(a,b){var c=Array.prototype.slice.call(arguments,1);return function(){var b=c.slice();b.push.apply(b,arguments);return a.apply(this,b)}}
var ha=Date.now||function(){return+new Date};
function v(a,b){var c=a.split("."),d=l;c[0]in d||!d.execScript||d.execScript("var "+c[0]);for(var e;c.length&&(e=c.shift());)!c.length&&m(b)?d[e]=b:d[e]?d=d[e]:d=d[e]={}}
function w(a,b){function c(){}
c.prototype=b.prototype;a.u=b.prototype;a.prototype=new c;a.prototype.constructor=a;a.H=function(a,c,f){for(var g=Array(arguments.length-2),h=2;h<arguments.length;h++)g[h-2]=arguments[h];return b.prototype[c].apply(a,g)}}
;var x;var ia=String.prototype.trim?function(a){return a.trim()}:function(a){return a.replace(/^[\s\xa0]+|[\s\xa0]+$/g,"")},ka=/&/g,la=/</g,ma=/>/g,na=/"/g,oa=/'/g,pa=/\x00/g,qa=/[\x00&<>"']/;
function ra(a){var b=new RegExp("/".replace(/([-()\[\]{}+?*.$\^|,:#<!\\])/g,"\\$1").replace(/\x08/g,"\\x08"),"");return a.replace(b,"")}
function sa(a,b){return a<b?-1:a>b?1:0}
;var ta=Array.prototype.indexOf?function(a,b,c){return Array.prototype.indexOf.call(a,b,c)}:function(a,b,c){c=null==c?0:0>c?Math.max(0,a.length+c):c;
if(r(a))return r(b)&&1==b.length?a.indexOf(b,c):-1;for(;c<a.length;c++)if(c in a&&a[c]===b)return c;return-1},ua=Array.prototype.forEach?function(a,b,c){Array.prototype.forEach.call(a,b,c)}:function(a,b,c){for(var d=a.length,e=r(a)?a.split(""):a,f=0;f<d;f++)f in e&&b.call(c,e[f],f,a)},va=Array.prototype.filter?function(a,b,c){return Array.prototype.filter.call(a,b,c)}:function(a,b,c){for(var d=a.length,e=[],f=0,g=r(a)?a.split(""):a,h=0;h<d;h++)if(h in g){var k=g[h];
b.call(c,k,h,a)&&(e[f++]=k)}return e},wa=Array.prototype.map?function(a,b,c){return Array.prototype.map.call(a,b,c)}:function(a,b,c){for(var d=a.length,e=Array(d),f=r(a)?a.split(""):a,g=0;g<d;g++)g in f&&(e[g]=b.call(c,f[g],g,a));
return e};function xa(a){if(a.classList)return a.classList;a=a.className;return r(a)&&a.match(/\S+/g)||[]}
function za(a){a.classList?a=a.classList.contains("playing"):(a=xa(a),a=0<=ta(a,"playing"));return a}
function Ba(){var a=document.body;a.classList?a.classList.add("playing"):za(a)||(a.className+=0<a.className.length?" playing":"playing")}
function Ea(){var a=document.body;a.classList?a.classList.remove("playing"):za(a)&&(a.className=va(xa(a),function(a){return"playing"!=a}).join(" "))}
;function y(a,b,c){for(var d in a)b.call(c,a[d],d,a)}
function Fa(a){var b=Ga,c;for(c in b)if(a.call(void 0,b[c],c,b))return c}
;var z;a:{var Ha=l.navigator;if(Ha){var Ia=Ha.userAgent;if(Ia){z=Ia;break a}}z=""}function A(a){return-1!=z.indexOf(a)}
;function B(){this.a="";this.b=Ja}
B.prototype.w=!0;B.prototype.v=function(){return this.a};
function Ka(a){return a instanceof B&&a.constructor===B&&a.b===Ja?a.a:"type_error:SafeUrl"}
var La=/^(?:(?:https?|mailto|ftp):|[^&:/?#]*(?:[/?#]|$))/i;function Ma(a){if(a instanceof B)return a;a=a.w?a.v():String(a);La.test(a)||(a="about:invalid#zClosurez");return Na(a)}
var Ja={};function Na(a){var b=new B;b.a=a;return b}
Na("about:blank");function C(){this.a="";this.b=Oa}
C.prototype.w=!0;C.prototype.v=function(){return this.a};
var Oa={};function D(a){var b=new C;b.a=a;return b}
D("<!DOCTYPE html>");D("");D("<br>");function E(a,b){this.a=m(a)?a:0;this.b=m(b)?b:0}
E.prototype.ceil=function(){this.a=Math.ceil(this.a);this.b=Math.ceil(this.b);return this};
E.prototype.floor=function(){this.a=Math.floor(this.a);this.b=Math.floor(this.b);return this};
E.prototype.round=function(){this.a=Math.round(this.a);this.b=Math.round(this.b);return this};function Pa(a){Pa[" "](a);return a}
Pa[" "]=aa;function Qa(a,b){try{return Pa(a[b]),!0}catch(c){}return!1}
function Ra(a,b){var c=Sa;return Object.prototype.hasOwnProperty.call(c,a)?c[a]:c[a]=b(a)}
;var Ta=A("Opera"),F=A("Trident")||A("MSIE"),Ua=A("Edge"),Va=Ua||F,G=A("Gecko")&&!(-1!=z.toLowerCase().indexOf("webkit")&&!A("Edge"))&&!(A("Trident")||A("MSIE"))&&!A("Edge"),J=-1!=z.toLowerCase().indexOf("webkit")&&!A("Edge");function Wa(){var a=l.document;return a?a.documentMode:void 0}
var Xa;a:{var Ya="",Za=function(){var a=z;if(G)return/rv\:([^\);]+)(\)|;)/.exec(a);if(Ua)return/Edge\/([\d\.]+)/.exec(a);if(F)return/\b(?:MSIE|rv)[: ]([^\);]+)(\)|;)/.exec(a);if(J)return/WebKit\/(\S+)/.exec(a);if(Ta)return/(?:Version)[ \/]?(\S+)/.exec(a)}();
Za&&(Ya=Za?Za[1]:"");if(F){var $a=Wa();if(null!=$a&&$a>parseFloat(Ya)){Xa=String($a);break a}}Xa=Ya}var ab=Xa,Sa={};
function K(a){return Ra(a,function(){for(var b=0,c=ia(String(ab)).split("."),d=ia(String(a)).split("."),e=Math.max(c.length,d.length),f=0;0==b&&f<e;f++){var g=c[f]||"",h=d[f]||"";do{g=/(\d*)(\D*)(.*)/.exec(g)||["","","",""];h=/(\d*)(\D*)(.*)/.exec(h)||["","","",""];if(0==g[0].length&&0==h[0].length)break;b=sa(0==g[1].length?0:parseInt(g[1],10),0==h[1].length?0:parseInt(h[1],10))||sa(0==g[2].length,0==h[2].length)||sa(g[2],h[2]);g=g[3];h=h[3]}while(0==b)}return 0<=b})}
var bb=l.document,cb=bb&&F?Wa()||("CSS1Compat"==bb.compatMode?parseInt(ab,10):5):void 0;!G&&!F||F&&9<=Number(cb)||G&&K("1.9.1");F&&K("9");function db(a,b){var c;c=b instanceof B?b:Ma(b);a.href=Ka(c)}
;function L(a){return 9==a.nodeType?a:a.ownerDocument||a.document}
function eb(a){return fb(a,function(a){if(a="A"==a.nodeName)a=!0;return a},void 0)}
function fb(a,b,c){for(var d=0;a&&(null==c||d<=c);){if(b(a))return a;a=a.parentNode;d++}return null}
function M(a){this.a=a||l.document||document}
M.prototype.createElement=function(a){return this.a.createElement(String(a))};
M.prototype.isElement=function(a){return da(a)&&1==a.nodeType};var gb=p("yt.dom.getNextId_");if(!gb){gb=function(){return++ib};
v("yt.dom.getNextId_",gb);var ib=0};var jb=window.yt&&window.yt.config_||window.ytcfg&&window.ytcfg.data_||{};v("yt.config_",jb);v("yt.tokens_",window.yt&&window.yt.tokens_||{});var kb=window.yt&&window.yt.msgs_||p("window.ytcfg.msgs")||{};v("yt.msgs_",kb);function lb(a){nb(jb,arguments)}
function N(a,b){return a in jb?jb[a]:b}
function ob(a){return a&&window.yterr?function(){try{return a.apply(this,arguments)}catch(d){var b=d,c=p("yt.logging.errors.log");c?c(b,void 0,void 0,void 0,void 0):(c=N("ERRORS",[]),c.push([b,void 0,void 0,void 0,void 0]),lb("ERRORS",c));throw d;}}:a}
function nb(a,b){if(1<b.length){var c=b[0];a[c]=b[1]}else{var d=b[0];for(c in d)a[c]=d[c]}}
;function O(a){this.type="";this.state=this.source=this.data=this.currentTarget=this.relatedTarget=this.target=null;this.charCode=this.keyCode=0;this.shiftKey=this.ctrlKey=this.altKey=!1;this.clientY=this.clientX=0;this.changedTouches=null;if(a=a||window.event){this.a=a;for(var b in a)b in pb||(this[b]=a[b]);(b=a.target||a.srcElement)&&3==b.nodeType&&(b=b.parentNode);this.target=b;if(b=a.relatedTarget)try{b=b.nodeName?b:null}catch(c){b=null}else"mouseover"==this.type?b=a.fromElement:"mouseout"==this.type&&
(b=a.toElement);this.relatedTarget=b;this.clientX=void 0!=a.clientX?a.clientX:a.pageX;this.clientY=void 0!=a.clientY?a.clientY:a.pageY;this.keyCode=a.keyCode?a.keyCode:a.which;this.charCode=a.charCode||("keypress"==this.type?this.keyCode:0);this.altKey=a.altKey;this.ctrlKey=a.ctrlKey;this.shiftKey=a.shiftKey}}
O.prototype.preventDefault=function(){this.a&&(this.a.returnValue=!1,this.a.preventDefault&&this.a.preventDefault())};
O.prototype.stopPropagation=function(){this.a&&(this.a.cancelBubble=!0,this.a.stopPropagation&&this.a.stopPropagation())};
O.prototype.stopImmediatePropagation=function(){this.a&&(this.a.cancelBubble=!0,this.a.stopImmediatePropagation&&this.a.stopImmediatePropagation())};
var pb={stopImmediatePropagation:1,stopPropagation:1,preventMouseEvent:1,preventManipulation:1,preventDefault:1,layerX:1,layerY:1,scale:1,rotation:1,webkitMovementX:1,webkitMovementY:1};var Ga=p("yt.events.listeners_")||{};v("yt.events.listeners_",Ga);var qb=p("yt.events.counter_")||{count:0};v("yt.events.counter_",qb);function rb(a,b,c,d){a.addEventListener&&("mouseenter"!=b||"onmouseenter"in document?"mouseleave"!=b||"onmouseenter"in document?"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"):b="mouseout":b="mouseover");return Fa(function(e){return e[0]==a&&e[1]==b&&e[2]==c&&e[4]==!!d})}
function P(a,b,c,d){if(a&&(a.addEventListener||a.attachEvent)){d=!!d;var e=rb(a,b,c,d);if(!e){var e=++qb.count+"",f=!("mouseenter"!=b&&"mouseleave"!=b||!a.addEventListener||"onmouseenter"in document),g;g=f?function(d){d=new O(d);if(!fb(d.relatedTarget,function(b){return b==a}))return d.currentTarget=a,d.type=b,c.call(a,d)}:function(b){b=new O(b);
b.currentTarget=a;return c.call(a,b)};
g=ob(g);a.addEventListener?("mouseenter"==b&&f?b="mouseover":"mouseleave"==b&&f?b="mouseout":"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"),a.addEventListener(b,g,d)):a.attachEvent("on"+b,g);Ga[e]=[a,b,c,g,d]}}}
;function sb(a){return/^\s*$/.test(a)?!1:/^[\],:{}\s\u2028\u2029]*$/.test(a.replace(/\\["\\\/bfnrtu]/g,"@").replace(/(?:"[^"\\\n\r\u2028\u2029\x00-\x08\x0a-\x1f]*"|true|false|null|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?)[\s\u2028\u2029]*(?=:|,|]|}|$)/g,"]").replace(/(?:^|:|,)(?:[\s\u2028\u2029]*\[)+/g,""))}
function tb(a){a=String(a);if(sb(a))try{return eval("("+a+")")}catch(b){}throw Error("Invalid JSON string: "+a);}
;function ub(){}
var vb="function"==typeof Uint8Array,wb=[];function Q(a){var b=xb;if(a<b.c){a+=b.f;var c=b.a[a];return c===wb?b.a[a]=[]:c}c=b.b[a];return c===wb?b.b[a]=[]:c}
ub.prototype.toString=function(){return this.a.toString()};function yb(a){a||(a=[]);this.f=-1;this.a=a;a:{if(this.a.length){a=this.a.length-1;var b=this.a[a];if(b&&"object"==typeof b&&!q(b)&&!(vb&&b instanceof Uint8Array)){this.c=a- -1;this.b=b;break a}}this.c=Number.MAX_VALUE}}
w(yb,ub);var zb=/^(?:([^:/?#.]+):)?(?:\/\/(?:([^/?#]*)@)?([^/#?]*?)(?::([0-9]+))?(?=[/#?]|$))?([^?#]+)?(?:\?([^#]*))?(?:#([\s\S]*))?$/;function Ab(a){return a?decodeURI(a):a}
function Bb(a,b,c,d){for(var e=c.length;0<=(b=a.indexOf(c,b))&&b<d;){var f=a.charCodeAt(b-1);if(38==f||63==f)if(f=a.charCodeAt(b+e),!f||61==f||38==f||35==f)return b;b+=e+1}return-1}
var Cb=/#|$/,Db=/[?&]($|#)/;function Eb(a,b){for(var c in a)Object.prototype.hasOwnProperty.call(a,c)&&b.call(void 0,a[c],c,a)}
function Fb(){var a=Gb;if(!a)return"";var b=/.*[&#?]google_debug(=[^&]*)?(&.*)?$/;try{var c=b.exec(decodeURIComponent(a));if(c)return c[1]&&1<c[1].length?c[1].substring(1):"true"}catch(d){}return""}
;function Hb(a,b){this.a=a;this.b=b}
function Ib(a,b){this.url=a;this.A=!!b;this.depth=null}
;function Jb(a,b,c){a.addEventListener?a.addEventListener(b,c,!1):a.attachEvent&&a.attachEvent("on"+b,c)}
;function Kb(a,b,c,d,e){this.h=c||4E3;this.c=a||"&";this.i=b||",$";this.f=m(d)?d:"trn";this.m=e||null;this.g=!1;this.b={};this.l=0;this.a=[]}
function Lb(a,b){var c={};c[a]=b;return[c]}
function R(a,b,c,d){a.a.push(b);a.b[b]=Lb(c,d)}
function Mb(a,b,c,d){b=b+"//"+c+d;var e=Nb(a)-d.length-0;if(0>e)return"";a.a.sort(function(a,b){return a-b});
d=null;c="";for(var f=0;f<a.a.length;f++)for(var g=a.a[f],h=a.b[g],k=0;k<h.length;k++){if(!e){d=null==d?g:d;break}var n=Ob(h[k],a.c,a.i);if(n){n=c+n;if(e>=n.length){e-=n.length;b+=n;c=a.c;break}else a.g&&(c=e,n[c-1]==a.c&&--c,b+=n.substr(0,c),c=a.c,e=0);d=null==d?g:d}}f="";a.f&&null!=d&&(f=c+a.f+"="+(a.m||d));return b+f+""}
function Nb(a){if(!a.f)return a.h;var b=1,c;for(c in a.b)b=c.length>b?c.length:b;return a.h-a.f.length-b-a.c.length-1}
function Ob(a,b,c,d,e){var f=[];Eb(a,function(a,h){var k=Pb(a,b,c,d,e);k&&f.push(h+"="+k)});
return f.join(b)}
function Pb(a,b,c,d,e){if(null==a)return"";b=b||"&";c=c||",$";"string"==typeof c&&(c=c.split(""));if(a instanceof Array){if(d=d||0,d<c.length){for(var f=[],g=0;g<a.length;g++)f.push(Pb(a[g],b,c,d+1,e));return f.join(c[d])}}else if("object"==typeof a)return e=e||0,2>e?encodeURIComponent(Ob(a,b,c,d,e+1)):"...";return encodeURIComponent(String(a))}
;function Qb(a,b,c,d,e,f){try{var g;c instanceof Kb?g=c:(g=new Kb,Eb(c,function(a,b){var c=g,d=c.l++,e=Lb(b,a);c.a.push(d);c.b[d]=e}));
if((d?a.g:Math.random())<(e||a.a)){var h=Mb(g,a.f,a.b,a.c+b+"&");"undefined"===typeof f?Rb(h):Rb(h,f)}}catch(k){}}
function Rb(a,b){l.google_image_requests||(l.google_image_requests=[]);var c=l.document.createElement("img");if(b){var d=function(a){b(a);a=d;c.removeEventListener?c.removeEventListener("load",a,!1):c.detachEvent&&c.detachEvent("onload",a);a=d;c.removeEventListener?c.removeEventListener("error",a,!1):c.detachEvent&&c.detachEvent("onerror",a)};
Jb(c,"load",d);Jb(c,"error",d)}c.src=a;l.google_image_requests.push(c)}
;function Sb(a,b,c){this.c=a;this.g=b;this.a=c;this.f=this.b}
function Tb(a,b,c){this.message=a;this.a=b||"";this.b=c||-1}
function Ub(a,b){var c;try{c=b()}catch(f){var d=a.a;try{var e=Vb(f),d=a.f.call(a,"osd_proto::reqm_int",e,void 0,void 0)}catch(g){a.b("pAR",g)}if(!d)throw f;}finally{}return c}
function Wb(a){var b=Xb;return function(){for(var c=[],d=0;d<arguments.length;++d)c[d]=arguments[d];return Ub(b,function(){return a.apply(void 0,c)})}}
Sb.prototype.b=function(a,b,c,d,e){try{var f=e||this.g,g=new Kb;g.g=!0;R(g,1,"context",a);b instanceof Tb||(b=Vb(b));R(g,2,"msg",b.message.substring(0,512));b.a&&R(g,3,"file",b.a);0<b.b&&R(g,4,"line",b.b.toString());b={};if(d)try{d(b)}catch(ba){}d=[b];g.a.push(5);g.b[5]=d;var h;e=l;d=[];var k,n=null;do{b=e;var ya;try{ya=!!b&&null!=b.location.href&&Qa(b,"foo")}catch(ba){ya=!1}ya?(k=b.location.href,n=b.document&&b.document.referrer||null):(k=n,n=null);d.push(new Ib(k||""));try{e=b.parent}catch(ba){e=
null}}while(e&&b!=e);k=0;for(var H=d.length-1;k<=H;++k)d[k].depth=H-k;b=l;if(b.location&&b.location.ancestorOrigins&&b.location.ancestorOrigins.length==d.length-1)for(k=1;k<d.length;++k){var Aa=d[k];Aa.url||(Aa.url=b.location.ancestorOrigins[k-1]||"",Aa.A=!0)}for(var Ca=new Ib(l.location.href,!1),Da=d.length-1,H=Da;0<=H;--H){var I=d[H];if(I.url&&!I.A){Ca=I;break}}var I=null,Jc=d.length&&d[Da].url;0!=Ca.depth&&Jc&&(I=d[Da]);h=new Hb(Ca,I);h.b&&R(g,6,"top",h.b.url||"");R(g,7,"url",h.a.url||"");Qb(this.c,
f,g,!1,c)}catch(ba){try{Qb(this.c,f,{context:"ecmserr",rctx:a,msg:Yb(ba),url:h.a.url},!1,c)}catch(ed){}}return this.a};
function Vb(a){return new Tb(Yb(a),a.fileName,a.lineNumber)}
function Yb(a){var b=a.toString();a.name&&-1==b.indexOf(a.name)&&(b+=": "+a.name);a.message&&-1==b.indexOf(a.message)&&(b+=": "+a.message);if(a.stack){a=a.stack;var c=b;try{-1==a.indexOf(c)&&(a=c+"\n"+a);for(var d;a!=d;)d=a,a=a.replace(/((https?:\/..*\/)[^\/:]*:\d+(?:.|\n)*)\2/,"$1");b=a.replace(/\n */g,"\n")}catch(e){b=c}}return b}
;var Zb=document,S=window;var $b,Xb;$b=new function(){this.f="http:"===S.location.protocol?"http:":"https:";this.b="pagead2.googlesyndication.com";this.c="/pagead/gen_204?id=";this.a=.01;this.g=Math.random()};
Xb=new Sb($b,"jserror",!0);function ac(a,b,c,d){if(d)c=a+("&"+b+"="+c);else{var e="&"+b+"=",f=a.indexOf(e);0>f?c=a+e+c:(f+=e.length,e=a.indexOf("&",f),c=0<=e?a.substring(0,f)+c+a.substring(e):a.substring(0,f)+c)}return 2E3<c.length?m(void 0)?ac(a,b,void 0,d):a:c}
;var bc=[0,2,1],cc=null;function dc(){var a=window.event||cc;if(!a)return null;var b;(b=a.which?1<<bc[a.which-1]:a.button)&&a.shiftKey&&(b|=8);b&&a.altKey&&(b|=16);b&&a.ctrlKey&&(b|=32);return b}
document.addEventListener&&document.addEventListener("mousedown",function(a){cc=a},!0);
window.mb=function(a){if(a){var b=dc();b&&(window.css?css(a.id,"mb",b,void 0,void 0):a&&(a.href=ac(a.href,"mb",b,void 0)))}};function T(){this.c=this.c;this.a=this.a}
T.prototype.c=!1;T.prototype.dispose=function(){this.c||(this.c=!0,this.i())};
T.prototype.i=function(){if(this.a)for(;this.a.length;)this.a.shift()()};
function ec(a){a&&"function"==typeof a.dispose&&a.dispose()}
;var fc=!F||9<=Number(cb),gc=F&&!K("9");!J||K("528");G&&K("1.9b")||F&&K("8")||Ta&&K("9.5")||J&&K("528");G&&!K("8")||F&&K("9");function hc(a,b){this.type=a;this.b=this.target=b;this.defaultPrevented=this.c=!1}
hc.prototype.stopPropagation=function(){this.c=!0};
hc.prototype.preventDefault=function(){this.defaultPrevented=!0};function U(a,b){hc.call(this,a?a.type:"");this.relatedTarget=this.b=this.target=null;this.charCode=this.keyCode=this.clientY=this.clientX=0;this.shiftKey=this.altKey=this.ctrlKey=!1;this.a=this.state=null;a&&this.init(a,b)}
w(U,hc);
U.prototype.init=function(a,b){var c=this.type=a.type,d=a.changedTouches?a.changedTouches[0]:null;this.target=a.target||a.srcElement;this.b=b;var e=a.relatedTarget;e?G&&(Qa(e,"nodeName")||(e=null)):"mouseover"==c?e=a.fromElement:"mouseout"==c&&(e=a.toElement);this.relatedTarget=e;null===d?(this.clientX=void 0!==a.clientX?a.clientX:a.pageX,this.clientY=void 0!==a.clientY?a.clientY:a.pageY):(this.clientX=void 0!==d.clientX?d.clientX:d.pageX,this.clientY=void 0!==d.clientY?d.clientY:d.pageY);this.keyCode=
a.keyCode||0;this.charCode=a.charCode||("keypress"==c?a.keyCode:0);this.ctrlKey=a.ctrlKey;this.altKey=a.altKey;this.shiftKey=a.shiftKey;this.state=a.state;this.a=a;a.defaultPrevented&&this.preventDefault()};
U.prototype.stopPropagation=function(){U.u.stopPropagation.call(this);this.a.stopPropagation?this.a.stopPropagation():this.a.cancelBubble=!0};
U.prototype.preventDefault=function(){U.u.preventDefault.call(this);var a=this.a;if(a.preventDefault)a.preventDefault();else if(a.returnValue=!1,gc)try{if(a.ctrlKey||112<=a.keyCode&&123>=a.keyCode)a.keyCode=-1}catch(b){}};var ic="closure_listenable_"+(1E6*Math.random()|0),jc=0;function kc(a,b,c,d,e){this.listener=a;this.a=null;this.src=b;this.type=c;this.s=!!d;this.b=e;this.key=++jc;this.j=this.o=!1}
function lc(a){a.j=!0;a.listener=null;a.a=null;a.src=null;a.b=null}
;function mc(a){this.src=a;this.a={};this.b=0}
mc.prototype.remove=function(a,b,c,d){a=a.toString();if(!(a in this.a))return!1;var e=this.a[a];b=nc(e,b,c,d);return-1<b?(lc(e[b]),Array.prototype.splice.call(e,b,1),0==e.length&&(delete this.a[a],this.b--),!0):!1};
function nc(a,b,c,d){for(var e=0;e<a.length;++e){var f=a[e];if(!f.j&&f.listener==b&&f.s==!!c&&f.b==d)return e}return-1}
;var oc="closure_lm_"+(1E6*Math.random()|0),pc={},qc=0;
function rc(a,b,c,d,e){if(q(b)){for(var f=0;f<b.length;f++)rc(a,b[f],c,d,e);return null}c=sc(c);if(a&&a[ic])a=tc(a,b,c,d,e);else{f=c;if(!b)throw Error("Invalid event type");c=!!d;var g=uc(a);g||(a[oc]=g=new mc(a));var h=g,k=b.toString(),g=h.a[k];g||(g=h.a[k]=[],h.b++);var n=nc(g,f,d,e);-1<n?(d=g[n],d.o=!1):(d=new kc(f,h.src,k,!!d,e),d.o=!1,g.push(d));if(!d.a){e=vc();d.a=e;e.src=a;e.listener=d;if(a.addEventListener)a.addEventListener(b.toString(),e,c);else if(a.attachEvent)a.attachEvent(wc(b.toString()),
e);else throw Error("addEventListener and attachEvent are unavailable.");qc++}a=d}return a}
function vc(){var a=xc,b=fc?function(c){return a.call(b.src,b.listener,c)}:function(c){c=a.call(b.src,b.listener,c);
if(!c)return c};
return b}
function yc(a){if("number"!=typeof a&&a&&!a.j){var b=a.src;if(b&&b[ic])b.a(a);else{var c=a.type,d=a.a;b.removeEventListener?b.removeEventListener(c,d,a.s):b.detachEvent&&b.detachEvent(wc(c),d);qc--;if(c=uc(b)){var d=a.type,e;if(e=d in c.a){e=c.a[d];var f=ta(e,a),g;(g=0<=f)&&Array.prototype.splice.call(e,f,1);e=g}e&&(lc(a),0==c.a[d].length&&(delete c.a[d],c.b--));0==c.b&&(c.src=null,b[oc]=null)}else lc(a)}}}
function wc(a){return a in pc?pc[a]:pc[a]="on"+a}
function zc(a,b,c,d){var e=!0;if(a=uc(a))if(b=a.a[b.toString()])for(b=b.concat(),a=0;a<b.length;a++){var f=b[a];f&&f.s==c&&!f.j&&(f=Ac(f,d),e=e&&!1!==f)}return e}
function Ac(a,b){var c=a.listener,d=a.b||a.src;a.o&&yc(a);return c.call(d,b)}
function xc(a,b){if(a.j)return!0;if(!fc){var c=b||p("window.event"),d=new U(c,this),e=!0;if(!(0>c.keyCode||void 0!=c.returnValue)){a:{var f=!1;if(0==c.keyCode)try{c.keyCode=-1;break a}catch(k){f=!0}if(f||void 0==c.returnValue)c.returnValue=!0}c=[];for(f=d.b;f;f=f.parentNode)c.push(f);for(var f=a.type,g=c.length-1;!d.c&&0<=g;g--){d.b=c[g];var h=zc(c[g],f,!0,d),e=e&&h}for(g=0;!d.c&&g<c.length;g++)d.b=c[g],h=zc(c[g],f,!1,d),e=e&&h}return e}return Ac(a,new U(b,this))}
function uc(a){a=a[oc];return a instanceof mc?a:null}
var Bc="__closure_events_fn_"+(1E9*Math.random()>>>0);function sc(a){if(t(a))return a;a[Bc]||(a[Bc]=function(b){return a.handleEvent(b)});
return a[Bc]}
;function V(a){T.call(this);this.f=a;this.b={}}
w(V,T);var Cc=[];function tc(a,b,c,d,e){q(c)||(c&&(Cc[0]=c.toString()),c=Cc);for(var f=0;f<c.length;f++){var g=rc(b,c[f],d||a.handleEvent,e||!1,a.f||a);if(!g)break;a.b[g.key]=g}return a}
function Dc(a){y(a.b,function(a,c){this.b.hasOwnProperty(c)&&yc(a)},a);
a.b={}}
V.prototype.i=function(){V.u.i.call(this);Dc(this)};
V.prototype.handleEvent=function(){throw Error("EventHandler.handleEvent not implemented");};function W(a,b,c){T.call(this);this.f=a;this.l=b;this.C=c;this.h=0;this.b={};this.g=new V(this);a=u(ec,this.g);this.c?m(void 0)?a.call(void 0):a():(this.a||(this.a=[]),this.a.push(m(void 0)?ga(a,void 0):a));Ec(this)}
w(W,T);function Ec(a){ua(a.C,function(a){tc(this.g,a.element,"mousedown",this.D,!0);tc(this.g,a.element,"mouseup",u(this.G,a),!0)},a);
tc(a.g,a.l,"mouseenter",a.F,void 0)}
function Fc(a,b){y(a.b,function(a,d){for(var e=b,f=e.search(Cb),g=0,h,k=[];0<=(h=Bb(e,g,d,f));)k.push(e.substring(g,h)),g=Math.min(e.indexOf("&",h)+1||f,f);k.push(e.substr(g));e=[k.join("").replace(Db,"$1"),"&",d];null!=a&&e.push("=",encodeURIComponent(String(a)));e[1]&&(f=e[0],g=f.indexOf("#"),0<=g&&(e.push(f.substr(g)),e[0]=f=f.substr(0,g)),g=f.indexOf("?"),0>g?e[1]="?":g==f.length-1&&(e[1]=void 0));b=e.join("")});
return b}
W.prototype.D=function(){this.m=ha()};
W.prototype.G=function(a,b){var c=a.element;1==(this.f&1)&&(0==this.h&&this.h++,this.b.nm=this.h);2==(this.f&2)&&(this.b.nb=a.B);if(8==(this.f&8)){var d=this.l,e=L(d),f=new E(0,0),g;g=e?L(e):document;g=!F||9<=Number(cb)||"CSS1Compat"==(g?new M(L(g)):x||(x=new M)).a.compatMode?g.documentElement:g.body;if(d!=g){var h;b:{try{h=d.getBoundingClientRect()}catch(k){h={left:0,top:0,right:0,bottom:0};break b}F&&d.ownerDocument.body&&(d=d.ownerDocument,h.left-=d.documentElement.clientLeft+d.body.clientLeft,
h.top-=d.documentElement.clientTop+d.body.clientTop)}d=(e?new M(L(e)):x||(x=new M)).a;e=d.scrollingElement?d.scrollingElement:J||"CSS1Compat"!=d.compatMode?d.body||d.documentElement:d.documentElement;d=d.parentWindow||d.defaultView;e=F&&K("10")&&d.pageYOffset!=e.scrollTop?new E(e.scrollLeft,e.scrollTop):new E(d.pageXOffset||e.scrollLeft,d.pageYOffset||e.scrollTop);f.a=h.left+e.a;f.b=h.top+e.b}this.b.nx=Math.round(b.clientX-f.a);this.b.ny=Math.round(b.clientY-f.b)}16==(this.f&16)&&null!=this.m&&(f=
ha()-this.m,this.b.clkt=f);512==(this.f&512)&&(f=dc())&&(this.b.mb=f);"A"==c.tagName.toUpperCase()&&db(c,Fc(this,c.href))};
W.prototype.F=function(){this.h++};if(Zb&&Zb.URL){var Gb=Zb.URL,Gc=!(Gb&&0<Fb().length);Xb.a=Gc};function Hc(a,b){this.b=a||0;this.a=b||""}
Hc.prototype.toString=function(){var a=""+this.b;this.a&&(a+="-"+this.a);return a};
function Ic(a){var b=[];y(a,function(a,d){var e=encodeURIComponent(d),f=a;r(f)&&(f=encodeURIComponent(f));b.push(e+"="+f)});
b.push("24="+(new Date).getTime());return b.join("\n")}
var Kc=0,Lc=0;function Mc(){var a=0,b=S;try{if(b&&b.Goog_AdSense_getAdAdapterInstance)return b}catch(d){}var c=b.location&&b.location.ancestorOrigins;if(m(c)&&(!c||!c.length))return null;for(;b&&5>a;){try{if(b.google_osd_static_frame)return b}catch(d){}try{if(b.aswift_0&&b.aswift_0.google_osd_static_frame)return b.aswift_0}catch(d){}a++;b=b!=b.parent?b.parent:null}return null}
function Nc(a,b,c,d,e,f,g){f=g||aa;if(10<Lc)S.clearInterval(Kc),f();else if(++Lc,S.postMessage&&(b.b||b.a)){if(f=Mc()){g={};b.b&&(g[4]=b.b);b.a&&(g[12]=b.a);g[0]="goog_request_monitoring";g[6]=a;g[16]=c;d&&d.length&&(g[17]=d.join(","));e&&(g[19]=e);try{var h=Ic(g);f.postMessage(h,"*")}catch(k){}}}else S.clearInterval(Kc),f()}
;function Oc(a,b,c){if(c.data){var d=c.data;if(r(d)){c={};for(var d=d.split("\n"),e=0;e<d.length;e++){var f=d[e].indexOf("=");if(!(0>=f)){var g=Number(d[e].substr(0,f)),f=d[e].substr(f+1);switch(g){case 5:case 8:case 11:case 15:case 16:case 18:f="true"==f;break;case 4:case 7:case 6:case 14:case 20:case 21:case 22:case 23:case 24:f=Number(f);break;case 3:case 19:if(t(decodeURIComponent))try{f=decodeURIComponent(f)}catch(h){throw Error("Error: URI malformed: "+f);}break;case 17:f=wa(decodeURIComponent(f).split(","),
Number)}c[g]=f}}c=c[0]?c:null}else c=null;c&&(d=new Hc(c[4],c[12]),a&&(a.b||a.a)&&(d.b||d.a)&&(a.a||d.a?a.a==d.a:(a.b||d.b)&&a.b==d.b)&&"goog_update_data"==c[0]&&(a=c[7],"number"==typeof a&&b(a)))}}
;var Pc={"pyv-embed":2,"pyv-embed-container":2,"pyv-embed-channel-image-overlay":19,"pyv-embed-channel-name-overlay":20,"pyv-embed-channel-banner-overlay":9,"pyv-embed-overlay":21,"pyv-embed-headline-overlay":0,"pyv-embed-description-overlay":7},Qc=!1,Rc=!1,X=null,xb=new yb,Y=null,Sc=!1,Tc=null,Uc=null;function Vc(){var a=0;Z("osd-1")?a=.01:Z("osd-25")?a=.25:Z("osd-50")?a=.5:Z("osd-75")&&(a=.75);null!=Uc&&Sc&&!Qc&&(Uc>=a?Y.playVideo():Y.pauseVideo())}
function Wc(){var a=15E3-1E3*Y.getCurrentTime();return 0<=a?a:0}
function Xc(){Y.mute();Z("osd")?(Sc=!0,Vc()):Y.playVideo()}
function Yc(a){if(Z("osd"))switch(a.data){case YT.PlayerState.PLAYING:null===X&&(0==Wc()?Zc():(Ba(),X=l.setTimeout(Zc,Wc())));break;case YT.PlayerState.PAUSED:null!=X&&(l.clearTimeout(X),X=null);0==Wc()&&Zc();break;case YT.PlayerState.ENDED:Ea(),Qc=!0}else switch(a.data){case YT.PlayerState.PLAYING:Rc||(Ba(),l.setTimeout(Zc,15E3),Rc=!0);break;case YT.PlayerState.ENDED:Ea()}}
function Zc(){Ea();Qc=!0;Y.stopVideo()}
function $c(){var a=N("PLAYER_CONFIG",void 0),b=N("VIDEO_ID",void 0),c=N("HOST",void 0);da(a)&&r(b)&&da(YT)&&t(YT.ready)&&t(YT.Player)&&YT.ready(function(){var d={height:"100%",width:"100%",videoId:b,playerVars:a,events:{onReady:Xc,onStateChange:Yc}};r(c)&&(d.host=c);Y=new YT.Player("iframe-player",d)})}
function ad(a){Uc=a;null===Y?$c():Vc()}
function bd(){var a=Q(1);Ab(a.match(zb)[3]||null)||(0==a.lastIndexOf("/",0)&&(a=ra(a)),a="https://googleads.g.doubleclick.net/"+a);var b=[],c=0;null!=Q(2)&&(c=Q(2));y(Pc,function(c,e){var f;f=document;if((f=r(e)?f.getElementById(e):e)&&(Z("background_click")||document.body.id!=e)&&(Z("container_click")||"pyv-embed-container"!=e)){var g=Z("background_click")||Z("container_click");"a"==f.nodeName.toLowerCase()?(db(f,a),g||P(f,"click",cd,!0)):(P(f,"click",u(dd,a)),P(f,"click",cd,!0));b.push({element:f,
B:c})}});
document.body&&!Z("dss")&&(Tc=new W(c,document.body,b))}
function Z(a){var b=N("RENDERING_EXPERIMENTS")||[];return q(b)&&0<=ta(b,a)}
function dd(a,b){var c;c=b||window.event;c=c.target||c.srcElement;3==c.nodeType&&(c=c.parentNode);if(a&&c&&!eb(c)){c=b||window.event;c.cancelBubble=!0;c.stopPropagation&&c.stopPropagation();null!=Tc&&(a=Fc(Tc,a));var d=a,e={target:"_blank"};c=window;var f;f=d instanceof B?d:Ma("undefined"!=typeof d.href?d.href:String(d));var d=e.target||d.target,g=[],h;for(h in e)switch(h){case "width":case "height":case "top":case "left":g.push(h+"="+e[h]);break;case "target":case "noreferrer":break;default:g.push(h+
"="+(e[h]?1:0))}h=g.join(",");(A("iPhone")&&!A("iPod")&&!A("iPad")||A("iPad")||A("iPod"))&&c.navigator&&c.navigator.standalone&&d&&"_self"!=d?(h=c.document.createElement("A"),db(h,f),h.setAttribute("target",d),e.noreferrer&&h.setAttribute("rel","noreferrer"),f=document.createEvent("MouseEvent"),f.initMouseEvent("click",!0,!0,c,1),h.dispatchEvent(f)):e.noreferrer?(h=c.open("",d,h),c=Ka(f),h&&(Va&&-1!=c.indexOf(";")&&(c="'"+c.replace(/'/g,"%27")+"'"),h.opener=null,qa.test(c)&&(-1!=c.indexOf("&")&&(c=
c.replace(ka,"&amp;")),-1!=c.indexOf("<")&&(c=c.replace(la,"&lt;")),-1!=c.indexOf(">")&&(c=c.replace(ma,"&gt;")),-1!=c.indexOf('"')&&(c=c.replace(na,"&quot;")),-1!=c.indexOf("'")&&(c=c.replace(oa,"&#39;")),-1!=c.indexOf("\x00")&&(c=c.replace(pa,"&#0;"))),c=D('<META HTTP-EQUIV="refresh" content="0; url='+c+'">'),h.document.write(c instanceof C&&c.constructor===C&&c.b===Oa?c.a:"type_error:SafeHtml"),h.document.close())):c.open(Ka(f),d,h)}}
function cd(){Qb($b,"pyv_user_click",{},!0,.1,void 0)}
;v("yt.setConfig",lb);v("yt.setMsg",function(a){nb(kb,arguments)});
P(window,"load",function(){Z("osd")||$c()});
P(window,"message",function(a){try{var b=tb(a.data)}catch(c){return}q(b)&&(xb=new yb(b),null!=Q(1)&&(bd(),Z("osd")&&null!=Q(3)&&(a=window,b=Q(3),b=new Hc(b,null),b.b||b.a)))&&(Jb(a,"message",u(Oc,b,ad)),Kc=S.setInterval(Wb(u(Nc,2,b,void 0,void 0,void 0,void 0)),500))});})();
