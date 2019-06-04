/*
 * 版 本 Glorint-Admin V1.0 供应链WMS()
 * Copyright (c) 2018 深圳国投供应链管理有限公司
 * 创建人：Admin
 * 日 期：2018.05.10
 * 描 述：客户端语言包加载（菜单，tab条）
 */
(function ($, learun) {
    "use strict";

    learun.language = {
        getMainCode: function () {
            return '';
        },
        get: function (text, callback) {
            callback(text);
        },
        getSyn: function (text) {
            return text;
        }
    };
})(window.jQuery, top.learun);