## References

* [asp-net-core](http://fiyazhasan.me/story-of-file-uploading-in-asp-net-core-part-i-mvc/)

## Screenshots

| ARC | ARC2 
| --- | --- 
| ![postman](screenshots/1.PNG?raw=true ) | ![postman](screenshots/2.PNG?raw=true )

## URL

```

POST https://localhost:44315/api/graphql 

```

### Model class for file uploads

```csharp

    public class AdModel
    {
        public IFormFileCollection AdImages { get; set; }
        public string AdId { get; set; }
        public string AdCaption { get; set; }
    }

```

