using System;

namespace tmsang.domain
{
    /**
     * No la mot Root cho viec dai dien tham chieu den cac loai Order - va cung xem nhu mot logic bussiness
     * Khong thuoc ve UserStory, nhung thuoc ve logic ky thuat
    */
    public class R_Order : BaseEntity, IAggregateRoot
    {
        public Guid Id { get; protected set; }
        public Guid AccountId { get; protected set; }
    }
}
