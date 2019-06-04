/* * 版 本 Glorint-Admin V1.0 供应链WMS()
 * Copyright (c) 2018 深圳国投供应链管理有限公司
 * 创建人：lyx
 * 日  期：2018-11-29 09:40
 * 描  述：Other_L
 */
var acceptClick;
var keyValue = request('keyValue'); //主键
var bootstrap = function ($, learun) {
    "use strict";
    var selectedRow = learun.frameTab.currentIframe().selectedRow;//获取表单编辑
    console.log(selectedRow)
    var ue; //富文本插件初始化
    var page = {
        init: function () {
            page.bind(); //
            page.initData();  //编辑加载页面
        },
        bind: function () {
         //加载事件
        //    $("#SeleteData").lrDataItemSelect({ code: 'SeleteData', maxHeight: 230 });  //字典数据配置绑定          
            ue = UE.getEditor('Editor'); //富文本插件编辑器
            $("#Files").lrUploader({ isUpload: false });  //模态上传窗口初始化            
            $('#Selects').lrselect({
                // 字段
                value: "F_AreaCode",
                text: "F_AreaName",
                title: "F_AreaName",
                type: 'multiple',
                // 展开最大高度
                maxHeight: 200,
                // 是否允许搜索
                allowSearch: true,
                // 访问数据接口地址
                url: top.$.rootUrl + '/LR_SystemModule/Area/Getlist',             
                // 访问数据接口参数
              //  param: { parentId: '' },
            });    
        },
        initData: function () {
            if (!!selectedRow) { //获取表单编辑
                //keyValue = selectedRow.ID;
                $('#form').lrSetFormData(selectedRow[0]);        //复选数组
            }
        }
    };
    // 保存数据
    acceptClick = function (callBack) {
        if (!$('#form').lrValidform()) {
            return false;
        }
        var postData = $('#form').lrGetFormData(); //获取表单内标签值保存
        postData["Editor"] = ue.getContent(null, null, true);  //编辑器插件赋值
        console.log(postData);
        $.lrSaveForm(top.$.rootUrl + '/Other_L/Other_L/SaveForm?keyValue=' + keyValue, postData, function (res) {
            // 保存成功后才回调
            if (!!callBack) {
                callBack();
            }
        });
    };
    page.init();
}
