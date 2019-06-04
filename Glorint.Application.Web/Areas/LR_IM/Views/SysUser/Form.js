﻿/*
 * 版 本 Glorint-Admin V1.0 供应链WMS()
 * Copyright (c) 2018 深圳国投供应链管理有限公司
 * 创建人：Admin
 * 日 期：2017.04.11
 * 描 述：即时通讯用户管理
 */
var keyValue = request('keyValue');

var acceptClick;
var bootstrap = function ($, learun) {
    "use strict";

    var page = {
        init: function () {
            // 验证编码是否重复
            $('#F_Code').on('blur', function () {
                $.lrExistField(keyValue, 'F_Code', top.$.rootUrl + '/LR_IM/SysUser/ExistCode');
            });
            // 选择图标
            $('#selectIcon').on('click', function () {
                learun.layerForm({
                    id: 'iconForm',
                    title: '选择图标',
                    url: top.$.rootUrl + '/Utility/Icon',
                    height: 700,
                    width: 1000,
                    btn: null,
                    maxmin: true,
                    end: function () {
                        if (top._learunSelectIcon != '') {
                            $('#F_Icon').val(top._learunSelectIcon);
                        }
                    }
                });
            });

            page.initData();
        },
        initData: function () {
            if (!!keyValue) {
                learun.httpAsync('GET', top.$.rootUrl + '/LR_IM/SysUser/GetFormData', { keyValue: keyValue }, function (data) {
                    $('#form').lrSetFormData(data);
                });
            }
        }
    };
    // 保存数据
    acceptClick = function (callBack) {
        if (!$('#form').lrValidform()) {
            return false;
        }
        var postData = $('#form').lrGetFormData(keyValue);
        $.lrSaveForm(top.$.rootUrl + '/LR_IM/SysUser/SaveForm?keyValue=' + keyValue, postData, function (res) {
            // 保存成功后才回调
            if (!!callBack) {
                callBack();
            }
        });
    };
    page.init();
}