using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class ImuName
{
   public const int pelvis_imu = 0;
   public int imu_id;


   public void Set(ImuName other)
   {
      imu_id = other.imu_id;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ImuName {");
      builder.Append("imu_id=");
      builder.Append(this.imu_id);
      builder.Append("}");
      return builder.ToString();
   }
}


}