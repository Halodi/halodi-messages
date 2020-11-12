using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class DrivingCommand
{
   /**
                 * Filter the desired x_dot and omega_z using a low pass filter 
                 * 
                 * Note: Commands sent to the "driving_command" will always be filtered
                 * 
                 */
   public bool filter_driving_commmand;
   /**
                 * Desired linear velocity
                 *
                 */
   public double linear_velocity;
   /**
                 *
                 *
                 */
   public double angular_velocity;


   public void Set(DrivingCommand other)
   {
      filter_driving_commmand = other.filter_driving_commmand;

      linear_velocity = other.linear_velocity;

      angular_velocity = other.angular_velocity;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("DrivingCommand {");
      builder.Append("filter_driving_commmand=");
      builder.Append(this.filter_driving_commmand);      builder.Append(", ");
      builder.Append("linear_velocity=");
      builder.Append(this.linear_velocity);      builder.Append(", ");
      builder.Append("angular_velocity=");
      builder.Append(this.angular_velocity);
      builder.Append("}");
      return builder.ToString();
   }
}


}