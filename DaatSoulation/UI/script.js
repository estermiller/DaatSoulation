function getNews(repeaterId) {
        $.ajax({
            type: "POST",
            url: "Default.aspx/GetNewsById",
            data: JSON.stringify({ id: repeaterId }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {

                // Handle the response from the server
                const titleHtml = '<h3>' + response.d.Title + '</h3>';
                const summaryHtml = '<p>' + response.d.Summary + '</p>';
                const linkHtml = '<a href="' + response.d.Link +'"target="_blank" id="readMore">Read more>></a>';
                $('#body').html(titleHtml +summaryHtml+linkHtml);
            },
            error: function (xhr, status, error) {
                console.error(error);
            }
        });
}
