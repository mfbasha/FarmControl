var mscc;!function(e){function t(e){for(var t=[],n=1;n<arguments.length;n++)t[n-1]=arguments[n];x[e]&&x[e].forEach(function(e){e.apply(null,t)})}function n(e,t){x[e]?x[e].push(t):x[e]=[t]}function o(e){if(e)for(var t=0,n=document.cookie.split("; ");t<n.length;t++){var o=n[t],a=o.indexOf("="),c=o.substring(0,a);if(c===e)return o.substring(c.length+1)}return null}function a(e,t,n){var a=new Date;a.setDate(a.getDate()+n);var c=A.split("."),i=c.pop();if("localhost"==i)document.cookie=e+"="+t+";expires="+a.toUTCString()+";path=/";else for(;o(e)!==t&&0!==c.length;)i=c.pop()+"."+i,document.cookie=e+"="+t+";expires="+a.toUTCString()+";path=/;domain=."+i}function c(e,t){return e.classList?e.classList.contains(t):new RegExp("(^| )"+t+"( |$)","gi").test(e.className)}function i(e,t){e.classList?e.classList.add(t):e.className+=" "+t}function s(e,t){e.classList?e.classList.remove(t):e.className=e.className.replace(new RegExp("(^|\\b)"+t.split(" ").join("|")+"(\\b|$)","gi")," ")}function r(e){return 13===e.which||13===e.keyCode}function u(){return void 0!=L&&c(L,I)}function m(e,t,n){if(!e&&!t)return!1;var o=e&&e.target||t;return(!o||0!==C(o))&&(o&&"A"===o.tagName?o!==S:m(null,o.parentElement,n))}function d(e,t,n){e.addEventListener?e.addEventListener(t,n):e.attachEvent("on"+t,function(){n.call(e)})}function l(e){if(B&&!M){var t=new Image,n=L.getAttribute("data-site-name"),o=L.getAttribute("data-nver"),a=L.getAttribute("data-sver"),c=n?"&s="+n:"",i=o?"&nv="+o:"",s=a?"&sv="+a:"",r=e?"&m="+e:"";t.src=y+"?o=mscc"+c+r+i+s,M=!0}}function f(){i(L,I),t("show"),l("show")}function v(){s(L,I),t("hide")}function g(e){return Math.floor(e/1e3)}function h(){var n=e.hasConsent();L&&v(),n||(a(e.cookieName,""+g(Date.now()),390),t("consent"))}function p(){var t={hasConsent:e.hasConsent(),consentDate:null};return t.hasConsent?(t.consentDate=new Date(1e3*+o(e.cookieName)),t):t}function k(){return!!o(e.cookieName)}function C(e){if(e&&e.getAttribute){var t=e.getAttribute(_);if("false"===t)return 0;if("true"===t)return 1}return-1}function b(t){var n=C(t.target),o=t.button;e.interactiveConsentEnabled&&0!==n&&(r(t)||0===o||1===o)&&(1===n||m(t,null,A))&&h()}function E(){L=document.getElementById("msccBanner"),S=document.getElementById("msccLearnMore");var t=k();!L||t||u()||f(),L&&t&&u()&&v(),t||(d(document.body,"mouseup",b),d(document.body,"keyup",b),d(document.body,"submit",h));var n=o(e.cookieName);n&&parseInt(n)<D&&d(window,"beforeunload",function(){a(e.cookieName,"0",-1)})}function N(){var t=o(e.cookieName);t&&parseInt(t)<0&&(document.cookie=e.cookieName+"=0;expires="+new Date(0).toUTCString()+";path=/;",a(e.cookieName,"0",-1))}function w(){o(e.cookieName);N(),null!=document.getElementById("msccBanner")||"complete"===document.readyState?E():document.addEventListener?document.addEventListener("DOMContentLoaded",E):document.attachEvent("onreadystatechange",function(){"complete"===document.readyState&&(E(),document.detachEvent("onreadystatechange",arguments.callee))})}e.cookieName="MSCC",e.version="0.3.7";var y="https://uhf.microsoft.com/_log",D=g(new Date("Sun, 01 Jan 2016 08:00:00 GMT").getTime());e.interactiveConsentEnabled=!0;var L,S,x={},A=window.location.hostname,I="active",_="data-mscc-ic",B=!0,M=!1;e._emit=t,e.on=n,e._getCookie=o,e._setCookieOnRootDomain=a,e.isVisible=u,e.setConsent=h,e.getConsentData=p,e.hasConsent=k,e._clearNegativeCookie=N,e._init=w,w()}(mscc||(mscc={}));