# Food website

## Infrastructure

[ASPNET React Web](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started)

![](https://itzone.com.vn/wp-content/uploads/2020/03/db5d517f-b0a9-4c2f-870a-3d688ede10cc.png)

## Structure

- project
  - Controllers
  - ClientApp

## Code Convention

**branch name:** feature/{short-feature-description}

## Development Enviromment

- install database
  `docker-compose up -d`

- run inital database
  `dotnet ef database update`

- run application
  `dotnet run`

### re-generate new database schema

`./Commands/reUpdateDatabase.sh`


### release
`./Commands/release.sh`


### Bank Info
- Ngân hàng	NCB
- Số thẻ	9704198526191432198
- Tên chủ thẻ	NGUYEN VAN A
- Ngày phát hành	07/15
- Mật khẩu OTP	123456


### Config undermaintenance

- hosts file
```
add the below line to hosts file
103.131.74.28 nhahanghoangtam.vn

Unix: /etc/hosts
Windows: C:\Windows\System32\drivers\etc\hosts


```

- Open chrome without SSL

```
Unix: /usr/bin/google-chrome-stable --ignore-certificate-errors

Windows: %ProgramFiles%\Google\Chrome\Application\chrome.exe --ignore-certificate-errors
```
````
### Status
- Directly + Vnpay: Success, Cancelled, Failed
- VNpay status sẽ tự động thanh đổi
- VNpay status Failed nếu hủy thanh toán hoặc có vấn đề trong lúc thanh toán
- Directly status sẽ mặc định là Success
- Field bắc buộc truyền xuống BE: Success, Cancelled, Failed
### PayStatus
- Directly + Vnpay: UnPaid, Paid, Failed, Invalid
- Field bắc buộc truyền xuống BE: UnPaid, Paid, Failed, Invalid
- Vnpay status sẽ tự động Paid nếu thanh toán thành công
- Vnpay status sẽ tự động thay đổi trạng thái Failed nếu đơn hàng hủy
- Vnpay status sẽ tự động thay đổi trạng thái Invalid nếu đơn gặp lỗi trong lúc giao dịch
- Nếu Direclty: Status sẽ là Unpaid khi khách hàng thanh toán nhân viên sẽ vào admin điều chỉnh status thành paid
### Statitics
totalOrder : Tổng số Order
totalSuccessOrder: Tổng số Order thành công
totalFailed (Thanh toán hủy): Tổng số Order thất bại bao gồm Invalid (gặp sự cố khi dao dịch)
totalCancellation: Tổng số Order hủy
totalRevenue: tổng doanh thu không bao gồm: Thanh toán thất bại, hủy
totalPaid: tổng doanh thu đã thanh toán không bao gồm: Thanh toán thất bại, hủy
totalUpaid: tổng doanh thu chưa thanh toán bao gồm: Thanh toán thất bại, hủy
totalRevenueByOnline: tổng doanh thu Online bao gồm: Thanh toán thất bại, hủy
totalRevenueByDirectly: tổng doanh thu thanh toán trực tiếp bao gồm: Thanh toán thất bại, hủy


## Production

### Cpanel
nhahanghoangtam.vn
zFZdQBr472f3