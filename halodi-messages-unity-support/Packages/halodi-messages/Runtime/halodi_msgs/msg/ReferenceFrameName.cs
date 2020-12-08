using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class ReferenceFrameName : Halodi.CDR.DataType<ReferenceFrameName>
{

	public Halodi.CDR.TopicDataType<ReferenceFrameName> Type => new ReferenceFrameNamePubSubType();
	
   /**
                * Robot world frame.
                *
                * Expressable in : YES
                * Controllable : NO
                */
   public const int WORLD = 0;
   /**
                * Pelvis (torso) of the robot. Origin is the intersection of the hip roll, pitch and yaw axes.
                *
                * Expressable in : YES
                * Controllable : Partial (z-height with respect to base expressed in world and orientation)
                */
   public const int PELVIS = 1;
   /**
                * Wheeled base frame of the robot. Origin is the intersection of the ankle roll and pitch axes.
                *
                * Expressable in : YES
                * Controllable : NO
                */
   public const int BASE = 2;
   /**
                * Left hand frame. Origin is the intersection of the left wrist roll, pitch and yaw axes
                *
                * Expressable in : YES
                * Controllable : YES
                */
   public const int LEFT_HAND = 3;
   /**
                * Right hand frame. Origin is the intersection of the right wrist roll, pitch and yaw axes
                *
                * Expressable in : YES
                * Controllable : YES
                */
   public const int RIGHT_HAND = 4;
   /**
                * Head frame. Origin is the base of the head.
                *
                * Expressable in : YES
                * Controllable : Partial (orientation pitch with respect to pelvis only)
                */
   public const int HEAD = 5;
   public int frame_id;


   public void Set(ReferenceFrameName other)
   {
      frame_id = other.frame_id;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ReferenceFrameName {");
      builder.Append("frame_id=");
      builder.Append(this.frame_id);
      builder.Append("}");
      return builder.ToString();
   }
}


}