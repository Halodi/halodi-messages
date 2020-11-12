using System.Text;
namespace halodi_msgs.msg
{


/**
          * Set the mode for the balance controller
          *
          * AUTOMATIC: The balance controller will try to stay stationary, but switch to driving if a driving command is received or the robot is pushed.
          * DRIVING: The balance controller is in driving mode. This allows faster reaction than AUTOMATIC, at the cost of less strict postion keeping
          * FOLLOW_ME: The balance controller heavily favours moving the base to balance, allowing easy pushing of the robot.
          * DISABLED: The balance controller will be disabled (CAUTION, NOT IMPLEMENTED)
          *
          */
[System.Serializable]
public class BalanceMode
{
   public const int AUTOMATIC = 0;
   public const int DRIVING = 1;
   public const int FOLLOW_ME = 2;
   public const int FORCE_STATIONARY = 3;
   public const int DISABLED = 84;
   public int mode;


   public void Set(BalanceMode other)
   {
      mode = other.mode;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("BalanceMode {");
      builder.Append("mode=");
      builder.Append(this.mode);
      builder.Append("}");
      return builder.ToString();
   }
}


}