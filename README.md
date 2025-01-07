## 如何使用github desktop克隆仓库到本地
* 配置完git（西二给了详细的教程→https://west2-online.feishu.cn/wiki/Lsz9w3CiGinXzgkevtmceHZknrf
* 下载github desktop（为了方便起见。如果你用命令行也可以不下载）
* 下载完打开，登录
* 本页面上面那个绿色的code，小三角下拉，找到HTTPS 下方的链接复制
* 回到软件，左上角File-Clone repository-URL，第一行粘贴链接，第二行选择一个地址用来放unity项目
* 点击Clone，完成

## github desktop简易操作指南
* git是一个版本管理工具，如果出现意外（比如写出bug把项目搞崩掉）就可以回溯到上一个版本。一般master分支是经过测试的稳定版本。
* 在做你的部分时，请点击上方Current branch，点击New branch创建一个你自己的分支
* Current branch旁边还有一个按钮（fetch），会根据你当前文件的状态来显示下载、上传等
* 在你当前的分支编写完后，然后先看左下这一栏，填写完Summary和description（一定要写！写你具体做了些什么），然后commit，接着按 ↑这个按钮就可以上传到github仓库
* 如果别人新上传了文件，你可以同样按这个按钮下载到你本地
* 你写的东西如果测试完没什么问题，就可以把你的分支合并到master里面，同样在Current branch里面可以找到merge，点merge合并你的分支到master。（如果合并分支时发现一个文件被两个人同时修改就会产生冲突，所以两个人最好不要同时修改同一个文件）

## 这些就是项目文件，不用再自己新建unity项目
