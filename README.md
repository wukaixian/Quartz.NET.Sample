# Quartz.NET.Sample
Quartz &amp; Topshelf Use Sample
###1、创建控制台应用程序
###2、引用Quartz
<code>
Install-Package Quartz
</code>
###3、引用Topshelf（结合Topshelf将任务安装成服务）
<code>
Install-Package Topshelf
</code>
###4引用Common.Logging.Log4Net1213（日志记录）
<code>
Install-Package Common.Logging.Log4Net1213 
</code>
###4、添加Quartz配置
添加quartz_jobs.xml、quartz.config，并将两个文件属性设置为始终复制。
###5、添加TestJob
添加TestJob 继承JobBase 实现Execute方法，方法内写执行任务代码。
###6、配置TestJob任务执行计划
在quartz_jobs中配置TestJob的schedule
###7、配置日志服务
在app.config配置日志项
###8、启动任务
直接启动控制台，任务程序启动，完成
###9 将任务部署为Window服务
执行服务安装
<code>
安装：Quartz.NET.Sample.exe install
启动：Quartz.NET.Sample.exe start
停止：Quartz.NET.Sample.exe stop
卸载：Quartz.NET.Sample.exe uninstall
</code>
