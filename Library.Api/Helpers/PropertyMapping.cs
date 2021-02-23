namespace Library.Api.Helpers {
    /// <summary>
    /// 属性映射
    /// 用于描述要映射的实体类属性
    /// </summary>
    public class PropertyMapping {
        /// <summary>
        /// 映射的目标属性
        /// </summary>
        public string TargetProperty { get; private set; }
        /// <summary>
        /// 是否顺序相反
        /// </summary>
        public bool IsRevert { get; private set; }

        public PropertyMapping(string targetProperty, bool revert = false) {
            TargetProperty = targetProperty;
            IsRevert = revert;
        }
    }
}