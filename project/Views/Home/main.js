$(document).ready(function() {
    var search = document.getElementById("search").value
    $.ajax({
        type: "GET",
        url: "https://api.bookshare.org/book/search/title/Harry%20Potter/page/1/limit/1/format/json?api_key=e5u4hptkxbz8bgh57jmsnf9n",
        dataType: "jsonp",
        success: function (data) {
            console.log("data", data);
        }
    })
});
