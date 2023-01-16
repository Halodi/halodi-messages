using System.IO;
namespace actionlib_msgs.msg
{

/**
* 
* Topic data type of the struct "GoalID" defined in "GoalID.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from GoalID.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit GoalID.idl instead.
*
*/
public class GoalIDPubSubType : Halodi.CDR.TopicDataType<GoalID>
{
   public override string Name => "actionlib_msgs::msg::dds_::GoalID_";


   public static int getCdrSerializedSize(actionlib_msgs.msg.GoalID data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(actionlib_msgs.msg.GoalID data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += builtin_interfaces.msg.TimePubSubType.getCdrSerializedSize(data.stamp, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.id.Length + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(actionlib_msgs.msg.GoalID data, Halodi.CDR.CDRSerializer cdr)
   {
      builtin_interfaces.msg.TimePubSubType.write(data.stamp, cdr);

      cdr.write_type_d(data.id);

   }

   public static void read(actionlib_msgs.msg.GoalID data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.stamp = builtin_interfaces.msg.TimePubSubType.Create();
      builtin_interfaces.msg.TimePubSubType.read(data.stamp, cdr);
      	
      data.id = cdr.read_type_d();	

   }


	public override void Serialize(actionlib_msgs.msg.GoalID data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(actionlib_msgs.msg.GoalID data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(actionlib_msgs.msg.GoalID data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(actionlib_msgs.msg.GoalID src, actionlib_msgs.msg.GoalID target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(actionlib_msgs.msg.GoalID src, actionlib_msgs.msg.GoalID target)
    {
    	Copy(src, target);
    }


}


}