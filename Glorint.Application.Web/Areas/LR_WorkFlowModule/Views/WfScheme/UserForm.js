﻿/*
 * 版 本 Glorint-Admin V1.0 供应链WMS()
 * Copyright (c) 2018 深圳国投供应链管理有限公司
 * 创建人：Admin
 * 日 期：2017.04.18
 * 描 述：角色添加	
 */
var acceptClick;
var auditorName = '';
var bootstrap = function ($, learun) {
    "use strict";
    var page = {
        init: function () {
            page.bind();
        },
        bind: function () {
            $('#auditorId').lrselect({
                value: 'F_UserId',
                text: 'F_RealName',
                title: 'F_RealName',
                // 展开最大高度
                maxHeight: 110,
                // 是否允许搜索
                allowSearch: true,
                select: function (item) {
                    auditorName = item.F_RealName;
                }
            });
            $('#department').lrDepartmentSelect({
                maxHeight: 150
            }).on('change', function () {
                var value = $(this).lrselectGet();
                $('#auditorId').lrselectRefresh({
                    url: top.$.rootUrl + '/LR_OrganizationModule/User/GetList',
                    param: { departmentId: value }
                });
            });
        }
    };
    // 保存数据
    acceptClick = function (callBack) {
        if (!$('#form').lrValidform()) {
            return false;
        }
        var formData = $('#form').lrGetFormData();
        formData.auditorName = auditorName;
        formData.type = '3';//审核者类型1.岗位2.角色3.用户
        callBack(formData);
        return true;
    };
    page.init();
}