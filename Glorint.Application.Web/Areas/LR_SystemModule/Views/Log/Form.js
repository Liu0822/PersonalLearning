/*
 * 版 本 Glorint-Admin V1.0 供应链WMS()
 * Copyright (c) 2018 深圳国投供应链管理有限公司
 * 创建人：Admin
 * 日 期：2017.04.11
 * 描 述：清空日志管理	
 */
var categoryId = request('categoryId');
var acceptClick;
var bootstrap = function ($, learun) {
    "use strict";

    var page = {
        init: function () {
            $('#keepTime').lrselect({maxHeight:75,placeholder:false}).lrselectSet(7);
        }
    };
    // 保存数据
    acceptClick = function (callBack) {
        if (!$('#form').lrValidform()) {
            return false;
        }
        var postData = $('#form').lrGetFormData();
        postData['categoryId'] = categoryId;
        $.lrSaveForm(top.$.rootUrl + '/LR_SystemModule/Log/SaveRemoveLog', postData, function (res) {
            // 保存成功后才回调
            if (!!callBack) {
                callBack();
            }
        });
    };
    page.init();
}