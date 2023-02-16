 //Converting base64 data to image
        public ImageSource CustomerImage
        {
            get
            {
                try
                {
                    if (HasImage)
                    {
                        byte[] imageBytes = Convert.FromBase64String(img_data);
                        _imageSource = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(img_data)));
                        return _imageSource;
                    }
                    else
                    {
                        return _imageSource = null;
                    }
                }
                catch
                {
                    return _imageSource = null;
                }
            }
        }
