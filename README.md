# PracticeXUnit
Mỗi test class được thực thi song song, vì mỗi test class đc assume là một category
Có thể khai báo collection để gộp các test class lại thành 1 category => thực thi tuần tự in one thread

Nhưng nếu muốn thực thi song song để nhanh, hiệu quả hơn thì sao? Delete Collection
Để kiểm soát thứ tự test nếu thực thi tuần tự? Using ITestCollectionOrderer
Test Driven Developemnt - Viet test truoc khi viet body cua ham => Meet cac requirements, neu sai thi test fail
