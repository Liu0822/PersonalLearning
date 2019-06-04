/*
 * 版 本 Glorint-Admin V1.0 供应链WMS()
 * Copyright (c) 2018 深圳国投供应链管理有限公司
 * 创建人：Admin
 * 日 期：2017.04.11
 * 描 述：列表字段添加	
 */
var id = request('id');

var acceptClick;
var bootstrap = function ($, learun) {
    "use strict";
    var formscheme = top.layer_Form.formscheme;
    var formFields = top.layer_Form.formFields;
    var colData = top.layer_Form.colData;


    var fieldName = '';
    var compontId = '';

    var page = {
        init: function () {
            page.bind();
            page.initData();
        },
        bind: function () {
            $('#fieldId').lrselect({
                text: 'title',
                value: 'field',
                data: formFields,
                allowSearch: true,
                select: function (item) {
                    fieldName = item.title;
                    compontId = item.id;
                }
            });
            // 所在行所占比
            $('#align').lrselect().lrselectSet('left');
        },
        initData: function () {
            if (!!id) {
                for (var i = 0, l = colData.length; i < l; i++) {
                    if (colData[i].id == id) {
                        $('#form').lrSetFormData(colData[i]);
                        break;
                    }
                }
            }
        }
    };
    // 保存数据
    acceptClick = function (callBack) {
        if (!$('#form').lrValidform()) {
            return false;
        }
        var postData = $('#form').lrGetFormData();
        postData.id = id || learun.newGuid();
        postData.fieldName = fieldName;
        postData.compontId = compontId;
        callBack(postData);
        return true;
    };
    page.init();
}