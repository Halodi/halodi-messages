using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class JointName
{
   public const int HIP_YAW = 0;
   public const int HIP_ROLL = 1;
   public const int HIP_PITCH = 2;
   public const int KNEE_PITCH = 3;
   public const int ANKLE_ROLL = 4;
   public const int ANKLE_PITCH = 5;
   public const int LEFT_SHOULDER_PITCH = 6;
   public const int LEFT_SHOULDER_ROLL = 7;
   public const int LEFT_SHOULDER_YAW = 8;
   public const int LEFT_ELBOW_PITCH = 9;
   public const int LEFT_ELBOW_YAW = 10;
   public const int LEFT_WRIST_PITCH = 11;
   public const int LEFT_WRIST_ROLL = 12;
   public const int RIGHT_SHOULDER_PITCH = 13;
   public const int RIGHT_SHOULDER_ROLL = 14;
   public const int RIGHT_SHOULDER_YAW = 15;
   public const int RIGHT_ELBOW_PITCH = 16;
   public const int RIGHT_ELBOW_YAW = 17;
   public const int RIGHT_WRIST_PITCH = 18;
   public const int RIGHT_WRIST_ROLL = 19;
   public const int NECK_PITCH = 20;
   public const int LEFT_WHEEL = 21;
   public const int RIGHT_WHEEL = 22;
   public int joint_id;


   public void Set(JointName other)
   {
      joint_id = other.joint_id;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("JointName {");
      builder.Append("joint_id=");
      builder.Append(this.joint_id);
      builder.Append("}");
      return builder.ToString();
   }
}


}