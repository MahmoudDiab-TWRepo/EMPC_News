﻿/**!
 * lg-share.js | 1.3.0 | May 20th 2020
 * http://sachinchoolur.github.io/lg-share.js
 * Copyright (c) 2016 Sachin N; 
 * @license GPLv3 
 */ !function (e) { if ("object" == typeof exports && "undefined" != typeof module) module.exports = e(); else if ("function" == typeof define && define.amd) define([], e); else { var t; (t = "undefined" != typeof window ? window : "undefined" != typeof global ? global : "undefined" != typeof self ? self : this).LgShare = e() } }(function () { var e; return (function () { function e(t, r, o) { function a(n, i) { if (!r[n]) { if (!t[n]) { var l = "function" == typeof require && require; if (!i && l) return l(n, !0); if (s) return s(n, !0); var p = Error("Cannot find module '" + n + "'"); throw p.code = "MODULE_NOT_FOUND", p } var c = r[n] = { exports: {} }; t[n][0].call(c.exports, function (e) { return a(t[n][1][e] || e) }, c, c.exports, e, t, r, o) } return r[n].exports } for (var s = "function" == typeof require && require, n = 0; n < o.length; n++)a(o[n]); return a } return e })()({ 1: [function (t, r, o) { var a, s; a = this, s = function () { "use strict"; var e = Object.assign || function (e) { for (var t = 1; t < arguments.length; t++) { var r = arguments[t]; for (var o in r) Object.prototype.hasOwnProperty.call(r, o) && (e[o] = r[o]) } return e }, t = { share: !0, facebook: !0, facebookDropdownText: "Facebook", twitter: !0, twitterDropdownText: "Twitter", googlePlus: !0, googlePlusDropdownText: "GooglePlus", pinterest: !0, pinterestDropdownText: "Pinterest" }, r = function r(o) { return this.el = o, this.core = window.lgData[this.el.getAttribute("lg-uid")], this.core.s = e({}, t, this.core.s), this.core.s.share && this.init(), this }; r.prototype.init = function () { var e = this, t = '<button aria-label="Share" aria-haspopup="true" aria-expanded="false" id="lg-share" class="lg-icon"><ul class="lg-dropdown" style="position: absolute;">'; t += e.core.s.facebook ? '<li><a id="lg-share-facebook" target="_blank"><span class="lg-icon"></span><span class="lg-dropdown-text">' + this.core.s.facebookDropdownText + "</span></a></li>" : "", t += e.core.s.twitter ? '<li><a id="lg-share-twitter" target="_blank"><span class="lg-icon"></span><span class="lg-dropdown-text">' + this.core.s.twitterDropdownText + "</span></a></li>" : "", t += e.core.s.googlePlus ? '<li><a id="lg-share-googleplus" target="_blank"><span class="lg-icon"></span><span class="lg-dropdown-text">' + this.core.s.googlePlusDropdownText + "</span></a></li>" : "", t += e.core.s.pinterest ? '<li><a id="lg-share-pinterest" target="_blank"><span class="lg-icon"></span><span class="lg-dropdown-text">' + this.core.s.pinterestDropdownText + "</span></a></li>" : "", t += "</ul></button>", this.core.outer.querySelector(".lg-toolbar").insertAdjacentHTML("beforeend", t), this.core.outer.querySelector(".lg").insertAdjacentHTML("beforeend", '<div id="lg-dropdown-overlay"></div>'); var r = document.getElementById("lg-share"); utils.on(r, "click.lg", function () { utils.hasClass(e.core.outer, "lg-dropdown-active") ? (utils.removeClass(e.core.outer, "lg-dropdown-active"), r.setAttribute("aria-expanded", !1)) : (utils.addClass(e.core.outer, "lg-dropdown-active"), r.setAttribute("aria-expanded", !0)) }), utils.on(document.getElementById("lg-dropdown-overlay"), "click.lg", function () { utils.removeClass(e.core.outer, "lg-dropdown-active"), r.setAttribute("aria-expanded", !1) }), utils.on(e.core.el, "onAfterSlide.lgtm", function (t) { setTimeout(function () { e.core.s.facebook && document.getElementById("lg-share-facebook").setAttribute("href", "https://www.facebook.com/sharer/sharer.php?u=" + e.getSharePropsUrl(t.detail.index, "data-facebook-share-url")), e.core.s.twitter && document.getElementById("lg-share-twitter").setAttribute("href", "https://twitter.com/intent/tweet?text=" + e.getShareProps(t.detail.index, "data-tweet-text") + "&url=" + e.getSharePropsUrl(t.detail.index, "data-twitter-share-url")), e.core.s.googlePlus && document.getElementById("lg-share-googleplus").setAttribute("href", "https://plus.google.com/share?url=" + e.getSharePropsUrl(t.detail.index, "data-googleplus-share-url")), e.core.s.pinterest && document.getElementById("lg-share-pinterest").setAttribute("href", "http://www.pinterest.com/pin/create/button/?url=" + e.getSharePropsUrl(t.detail.index, "data-pinterest-share-url") + "&media=" + encodeURIComponent(e.getShareProps(t.detail.index, "href") || e.getShareProps(t.detail.index, "data-src")) + "&description=" + e.getShareProps(t.detail.index, "data-pinterest-text")) }, 100) }) }, r.prototype.getSharePropsUrl = function (e, t) { var r = this.getShareProps(e, t); return r || (r = window.location.href), encodeURIComponent(r) }, r.prototype.getShareProps = function (e, t) { var r, o = ""; return this.core.s.dynamic ? o = this.core.items[e][(r = t.replace("data-", "")).toLowerCase().replace(/-(.)/g, function (e, t) { return t.toUpperCase() })] : this.core.items[e].getAttribute(t) && (o = this.core.items[e].getAttribute(t)), o }, r.prototype.destroy = function () { }, window.lgModules.share = r }, "function" == typeof e && e.amd ? e([], s) : void 0 !== o ? s() : (s(), a.lgShare = {}) }, {}] }, {}, [1])(1) });