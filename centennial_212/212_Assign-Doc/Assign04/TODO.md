### 开发计划

#### 1. 项目初始化与数据库准备 (1小时)
- **任务**:
  - [x] 创建WPF应用程序项目。 ✅ 2025-03-27
  - [x] 添加类库项目用于数据模型和EF Core。 ✅ 2025-03-27
  - [x] 运行提供的`OMS.sql`脚本生成数据库。 ✅ 2025-03-27
  - [x] 配置EF Core连接数据库。 ✅ 2025-03-27
- **预估时间**: 1小时
SSS
#### 2. 数据模型与EF Core配置 (2小时)
- **任务**:
  - [x] 根据ER图创建数据模型类（`Shopper`, `Basket`, `BasketItem`, `Product`）。 ✅ 2025-03-27
  - [x] 配置DbContext和数据库迁移。 ✅ 2025-03-27
  - 实现数据访问的异步方法（如`GetAllShoppersAsync`, `GetBasketItemsAsync`等）。
- **预估时间**: 2小时

#### 3. 搬迁代码

- [x] 把assign3 的代码搬迁过来 ✅ 2025-03-27
- [x] 完成基本的界面修改 ✅ 2025-03-27
- [x] 改成mwwm 结构 ✅ 2025-03-27
#### 4. 数据访问工具类实现 (3小时)
- **任务**:
  - [x] 实现工具类`DataAccess`，包含以下异步方法： ✅ 2025-03-28
    - 获取购物者邮箱和Basket ID（用于ComboBox）。
    - 获取BasketItem数据（用于DataGrid）。
    - 获取产品信息（用于ComboBox）。
    - 保存新BasketItem到数据库（自动生成新ID）。
- **预估时间**: 3小时

#### 4. MainWindow与ViewModel实现 (2小时)
- **任务**:
  - 设计`MainWindow.xaml`，包含ComboBox和DataGrid。
  - 实现`MainWindowViewModel`，绑定ComboBox和DataGrid数据。
  - 处理ComboBox选择变化事件，更新DataGrid。
- **预估时间**: 2小时

#### 5. ListOrderDetailsView与ViewModel实现 (3小时)
- **任务**:
  - 设计`ListOrderDetailsView.xaml`，显示订单详情。
  - 实现`ListOrderDetailsViewModel`，绑定DataGrid数据。
  - 确保数据加载和显示的实时性。
- **预估时间**: 3小时

#### 6. AddNewItemView与ViewModel实现 (3小时)
- **任务**:
  - 设计`AddNewItemView.xaml`，包含两个ComboBox（Basket和Product）和输入字段。
  - 实现`AddNewItemViewModel`，绑定ComboBox数据和处理保存逻辑。
  - 实现保存功能，确保新BasketItem的ID正确生成。
- **预估时间**: 3小时

#### 7. 功能测试与调试 (2小时)
- **任务**:
  - 测试ComboBox数据加载是否正确。
  - 测试DataGrid是否随ComboBox选择变化而更新。
  - 测试新增BasketItem功能是否正常。
  - 修复发现的BUG。
- **预估时间**: 2小时

#### 8. 代码优化与文档 (1小时)
- **任务**:
  - 优化代码结构，确保可读性和可维护性。
  - 添加必要的注释。
  - 生成最终提交的ZIP文件。
- **预估时间**: 1小时

### 总预估时间: 17小时

### 时间分配建议
- **前期准备**（数据库和模型）：3小时
- **核心功能开发**（数据访问和UI）：8小时
- **测试与优化**：4小时
- **缓冲时间**：2小时（应对不可预见问题）

### 注意事项
1. **异步编程**：确保所有数据库操作使用异步方法。
2. **MVVM模式**：严格分离View、ViewModel和Model。
3. **数据绑定**：充分利用WPF的数据绑定功能，减少后台代码。
4. **异常处理**：添加必要的异常处理逻辑，确保程序健壮性。

按此计划分步实施，可高效完成作业要求。