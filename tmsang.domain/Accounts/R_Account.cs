using System;

namespace tmsang.domain
{
    /**
     * No la mot Root cho viec dai dien tham chieu den cac loai Account - va cung xem nhu mot logic bussiness
     * Khong thuoc ve UserStory, nhung thuoc ve logic ky thuat
    */
    public class R_Account: BaseEntity, IAggregateRoot
    {
        public virtual Guid Id { get; protected set; }
        public virtual int AccountStatusId { get; protected set; }          // [-1(deleted), 0(disactive), 1(active)]
    }
}
