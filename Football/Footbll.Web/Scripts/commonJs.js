function ajax(strUrl, strData, backfunc) {
    $.ajax({
        url: strUrl,
        async: false,
        type: "Post",
        data: strData,
        dataType: "text",
        success: backfunc
    });
}

function ajaxJson(strUrl, strData, backfunc) {
    $.ajax({
        url: strUrl,
        async: false,
        type: "Post",
        data: strData,
        dataType: "json",
        success: backfunc
    });
}