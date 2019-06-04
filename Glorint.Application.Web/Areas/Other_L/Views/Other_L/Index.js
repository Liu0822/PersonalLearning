/* * 版 本 Glorint-Admin V1.0 供应链WMS()
 * Copyright (c) 2018 深圳国投供应链管理有限公司
 * 创建人：lyx
 * 日  期：2018-11-29 09:40
 * 描  述：Other_L
 */
var selectedRow;
var refreshGirdData; //初始化搜索参数
var bootstrap = function ($, learun) {
    "use strict";
    var page = {
        init: function () {
            page.initGird();
            page.bind();
        },
        bind: function () {
            // 查询
            $('#btn_Search').on('click', function () {
                var keyword = $('#txt_Keyword').val();
                page.search({ keyword: keyword });
            });
            // 刷新
            $('#lr_refresh').on('click', function () {
                location.reload();
            });
            // 新增
            $('#lr_add').on('click', function () {
                selectedRow = null;
                learun.layerForm({
                    id: 'form',
                    title: '新增',
                    url: top.$.rootUrl + '/Other_L/Other_L/Form',
                    width: 1000,
                    height: 700,
                    callBack: function (id) {
                        return top[id].acceptClick(refreshGirdData);
                    }
                });
            });
            //打印
            $('#lr-print').on('click', function () {
                //$("#gridtable").jqprintTable({ title: '测试打印' });
                $("#gridtable").jqprintTable();
            });
            // 单条编辑
            $('#lr_edit').on('click', function () {
                selectedRow = $('#gridtable').jfGridGet('rowdata');
                var keyValue = $('#gridtable').jfGridValue('ID');
                if (learun.checkrow(keyValue)) {
                    if (selectedRow.length == 1) {
                        learun.layerForm({
                            id: 'form',
                            title: '编辑',
                            url: top.$.rootUrl + '/Other_L/Other_L/Form?keyValue=' + keyValue,
                            width: 1000,
                            height: 700,
                            callBack: function (id) {
                                return top[id].acceptClick(refreshGirdData);
                            }
                        });
                    }
                    else {
                        learun.alert.warning("请选中一条进行编辑操作！");
                    }
                }
            });
            // 删除
            $('#lr_delete').on('click', function () {
                var keyValue = $('#gridtable').jfGridValue('ID');  //获取id
                var ids = $('#gridtable').jfGridGet('rowdata');   //获取点击的条数和行数据     
                console.log(ids);
                if (learun.checkrow(keyValue)) {
                    if (ids.length == 1) {
                        learun.layerConfirm('是否确认删除该项! ', function (res) {
                            if (res) {
                                learun.deleteForm(top.$.rootUrl + '/Other_L/Other_L/DeleteForm', { keyValue: keyValue }, function () {
                                    refreshGirdData();  //成功后刷新加载列表
                                });
                            }
                        });
                    }
                    else {
                        learun.layerConfirm('您正在批量删除，请核对选中信息！<br />(共' + ids.length + '条)', function (res) {
                            if (res) {
                                learun.deleteForm(top.$.rootUrl + '/Other_L/Other_L/DeleteForm', { keyValue: keyValue }, function () {
                                    refreshGirdData();
                                });
                            }
                        });
                    }
                }
            });
        },
        //列表数据
        initGird: function () {
            $('#gridtable').lrAuthorizeJfGrid({
                url: top.$.rootUrl + '/Other_L/Other_L/GetPageList',
                headData: [
                    { label: 'Name', name: 'Name', width: 200, align: "left" },
                    { label: 'Title', name: 'Title', width: 200, align: "left" },
                    { label: 'Files', name: 'Files', width: 200, align: "left" },
                    { label: 'Selects', name: 'Selects', width: 200, align: "left" },
                    { label: 'Editor', name: 'Editor', width: 200, align: "left" },
                ],
                mainId: 'ID',
                isPage: true,  //是否分页
                isMultiselect: true,//是否复选
                //  isEdit: true,
            });
            page.search();
        },
        search: function (param) {
            param = param || {};
            $('#gridtable').jfGridSet('reload', { queryJson: JSON.stringify(param) });
        }
    };
    //搜索框参数
    refreshGirdData = function () {
        var keyword = $('#txt_Keyword').val();
        page.search({ keyword: keyword });
    };
    page.init();
}
