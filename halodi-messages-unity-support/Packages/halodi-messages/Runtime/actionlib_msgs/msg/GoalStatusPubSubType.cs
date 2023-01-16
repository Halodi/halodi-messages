using System.IO;
namespace actionlib_msgs.msg
{

/**
* 
* Topic data type of the struct "GoalStatus" defined in "GoalStatus.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from GoalStatus.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit GoalStatus.idl instead.
*
*/
public class GoalStatusPubSubType : Halodi.CDR.TopicDataType<GoalStatus>
{
   public override string Name => "actionlib_msgs::msg::dds_::GoalStatus_";


   public static int getCdrSerializedSize(actionlib_msgs.msg.GoalStatus data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(actionlib_msgs.msg.GoalStatus data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += actionlib_msgs.msg.GoalIDPubSubType.getCdrSerializedSize(data.goal_id, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.text.Length + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(actionlib_msgs.msg.GoalStatus data, Halodi.CDR.CDRSerializer cdr)
   {
      actionlib_msgs.msg.GoalIDPubSubType.write(data.goal_id, cdr);

      cdr.write_type_9(data.status);

      cdr.write_type_d(data.text);

   }

   public static void read(actionlib_msgs.msg.GoalStatus data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.goal_id = actionlib_msgs.msg.GoalIDPubSubType.Create();
      actionlib_msgs.msg.GoalIDPubSubType.read(data.goal_id, cdr);
      	
      data.status=cdr.read_type_9();
      	
      data.text = cdr.read_type_d();	

   }


	public override void Serialize(actionlib_msgs.msg.GoalStatus data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(actionlib_msgs.msg.GoalStatus data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(actionlib_msgs.msg.GoalStatus data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(actionlib_msgs.msg.GoalStatus src, actionlib_msgs.msg.GoalStatus target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(actionlib_msgs.msg.GoalStatus src, actionlib_msgs.msg.GoalStatus target)
    {
    	Copy(src, target);
    }


}


}