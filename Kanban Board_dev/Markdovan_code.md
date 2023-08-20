
## no_test01

```py
 import os
        import shutil

        # Paths
        DOWNLOADS_PATH = os.path.expanduser(\Kanban Board_dev)
        # location
        ORGANIZED_PATHS = {
            'Documents': ['.pdf', '.doc', '.docx', '.txt', '.md', '.xlsx', '.ppt'],
            'Images': ['.jpg', '.jpeg', '.gif', '.png', '.svg'],
            'Music': ['.mp3', '.wav', '.wma', '.ogg', '.flac', '.aac'],
            'Videos': ['.mp4', '.mkw', '.flv', '.mov', '.avl'],
           # 'Archives': ['.zip', '.tar', '.tar.gz', '.rar', '.7z'],
        }
        def organize_downloads():
        for filename in os.listdir(DOWNLOADS_PATH):
        file_path = os.path.join(DOWNLOADS_PATH, filename)
        
        if not os.path.isfile(file_path):
        continue
        
        file_type = None
        for folder, extensions in ORGANIZED_PATHS.items():
        for extension in extensions:
        if filename.endswith(extension):
        file_type = folder
        break
        if file_type:
        break

        if  file_type:
        dest_folder = os.path.join(DOWNLOADS_PATH, file_type)
        os.makedirs(dest_folder, exist_ok=true)
        shutil.move(file_path, os.path.join(dest_folder, filename))
        else:
        pass
        if __name__ == "__main__":
        organize_downloads()

```

## yes_test02

```py
   <py-script>
     print('Hello, world!')
     name = 15
     print(name + 5)
    </py-script>
    <py-script> print([x for x in range(20)])</py-script>|
```
