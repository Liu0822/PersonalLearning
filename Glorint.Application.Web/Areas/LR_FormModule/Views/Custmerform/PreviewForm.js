/*
 * 版 本 Glorint-Admin V1.0 供应链WMS()
 * Copyright (c) 2018 深圳国投供应链管理有限公司
 * 创建人：Admin
 * 日 期：2017.04.17
 * 描 述：自定义表单预览	
 */
var keyValue = request('keyValue');
var schemeInfoId = request('schemeInfoId');
var schemeId = request('schemeId');

var bootstrap = function ($, learun) {
    "use strict";
    var formData;
    var page = {
        init: function () {
            if (!!schemeInfoId) {
                $.lrSetForm(top.$.rootUrl + '/LR_FormModule/Custmerform/GetFormData?keyValue=' + schemeInfoId, function (data) {//
                    formData = JSON.parse(data.schemeEntity.F_Scheme);
                    $('body').lrCustmerFormRender(formData.data);
                });
            }
            else if (!!schemeId) {
                $.lrSetForm(top.$.rootUrl + '/LR_FormModule/Custmerform/GetSchemeEntity?keyValue=' + schemeId, function (res) {//
                    formData = JSON.parse(res.F_Scheme);
                    $('body').lrCustmerFormRender(formData.data);
                });
            }
            else if (!!keyValue) {
                formData = top[keyValue];
                $('body').lrCustmerFormRender(formData);
            }
        }
    };
    page.init();
}