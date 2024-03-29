﻿/*
 * 版 本 Glorint-Admin V1.0 供应链WMS()
 * Copyright (c) 2018 深圳国投供应链管理有限公司
 * 创建人：Admin
 * 日 期：2017.04.18
 * 描 述：岗位选择
 */
var dfopid = request('dfopid');
var selectValue = request('selectValue');

var acceptClick;
var bootstrap = function ($, learun) {
    "use strict";
    var postitem = { value: '', text: '' };

    var page = {
        init: function () {
            page.bind();
            page.initData();
        },
        bind: function () {
            $('#form_company_list').lrtree({
                url: top.$.rootUrl + '/LR_OrganizationModule/Company/GetTree',
                param: { parentId: '0' },
                nodeClick: function (item) {
                    $('#form_post_list').lrtreeSet('refresh', {
                        url: top.$.rootUrl + '/LR_OrganizationModule/Post/GetTree',
                        param: { companyId: item.id }
                    });
                }
            });

            $('#form_post_list').lrtree({
                nodeClick: function (item) {
                    postitem.value = item.id;
                    postitem.text = item.text;
                }
            });


            $('.form-post-search>input').on("keypress", function (e) {
                if (event.keyCode == "13") {
                    var keyword = $(this).val();
                    $('#form_post_list').lrtreeSet('search', { keyword: keyword });

                }
            });
        },
        initData: function () {
            if (!!selectValue && selectValue != "0") {
                learun.httpAsync('GET', top.$.rootUrl + '/LR_OrganizationModule/Post/GetEntity', { keyValue: selectValue }, function (data) {
                    if (!!data) {
                        $('#form_company_list').lrtreeSet('setValue', data.F_CompanyId);
                        $('#form_post_list').lrtreeSet('setValue', data.F_PostId);
                    }
                });
            }
        }
    };
    // 保存数据
    acceptClick = function (callBack) {
        callBack(postitem, dfopid);
        return true;
    };
    page.init();
}