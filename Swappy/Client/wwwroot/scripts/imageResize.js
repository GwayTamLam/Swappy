window.blazorHelpers = {
    resizeAndConvertImage: function (file, maxWidth, maxHeight, dotNetReference) {
        const reader = new FileReader();
        reader.onload = event => {
            const img = new Image();
            img.onload = () => {
                let canvas = document.createElement('canvas');
                let width = img.width;
                let height = img.height;

                if (width > height) {
                    if (width > maxWidth) {
                        height *= maxWidth / width;
                        width = maxWidth;
                    }
                } else {
                    if (height > maxHeight) {
                        width *= maxHeight / height;
                        height = maxHeight;
                    }
                }

                canvas.width = width;
                canvas.height = height;
                let ctx = canvas.getContext('2d');
                ctx.drawImage(img, 0, 0, width, height);

                canvas.toBlob(blob => {
                    const reader = new FileReader();
                    reader.readAsDataURL(blob);
                    reader.onloadend = () => {
                        let base64data = reader.result;
                        dotNetReference.invokeMethodAsync('ReceiveResizedImage', base64data.split(',')[1]);
                    };
                }, 'image/jpeg');
            };
            img.src = event.target.result;
        };
        reader.readAsDataURL(file);
    }
};
