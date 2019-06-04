/*
 * 版 本 Glorint-Admin V1.0 供应链WMS()
 * Copyright (c) 2018 深圳国投供应链管理有限公司
 * 创建人：Admin
 * 日 期：2018.04.28
 * 描 述：桌面消息查看
 */
var id = request('id');
var bootstrap = function ($, learun) {
    "use strict";

    var page = {
        init: function () {
            var item = top['dtlist' + id];
            $('.title p').text(item.f_title);
            $('.con').html($('<div></div>').html(item.f_content).text());
        }
    };
    page.init();
}