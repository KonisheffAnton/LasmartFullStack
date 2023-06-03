$(document).ready(function () {
    var stage = new Konva.Stage({
        container: 'canvas-container',
        width: window.innerWidth,
        height: window.innerHeight
    });


    var layer = new Konva.Layer();
    stage.add(layer);

    $.ajax({
        url: '/api/v1/GetAllCircles',
        method: 'GET',
        success: function (circles) {
            circles.forEach(function (circle) {
                var circleShape = new Konva.Circle({
                    x: circle.positionX,
                    y: circle.positionY,
                    radius: circle.radius,
                    fill: '#' + circle.color
                });

                layer.add(circleShape);

                var commentY = circle.positionY + circle.radius + 10;

                circle.commentList.forEach(function (comment) {
                    var commentText = new Konva.Text({
                        id: comment.id + '_text',
                        width: 100,
                        height: 40,
                        text: comment.text,
                        fill: 'white',
                        fontSize: 12,
                        fontFamily: 'Arial',
                        padding: 10,
                        align: 'center'
                    });

                    var commentRect = new Konva.Rect({
                        id: comment.id + '_rect',
                        stroke: '#555',
                        strokeWidth: 2,
                        width: commentText.getTextWidth()+10,
                        height: 30,
                        fill: '#' + comment.color,
                    });

                    var commentXForRect = circle.positionX - commentRect.width() / 2;
                    var commentXForText = circle.positionX - commentText.width() / 2;
                    commentRect.position({ x: commentXForRect, y: commentY });
                    commentText.position({ x: commentXForText, y: commentY });

                    layer.add(commentRect);
                    layer.add(commentText);

                    commentY += commentRect.height() + 5;
                });

                circleShape.on('dblclick', function () {
                    $.ajax({
                        url: '/api/v1/DeleteCircle',
                        method: 'DELETE',
                        data: JSON.stringify(circle),
                        contentType: 'application/json',
                        success: function () {
                            circleShape.remove();
                            circle.commentList.forEach(function (comment) {
                                var commentRect = layer.findOne('#' + comment.id + '_rect');
                                var commentText = layer.findOne('#' + comment.id + '_text');
                                commentRect.remove();
                                commentText.remove();
                            });

                            layer.draw();
                        }
                    });
                });
            });

            layer.draw();
        }
    });
});
