using System.IO;
namespace action_msgs.msg
{

/**
* 
* Topic data type of the struct "GoalStatus" defined in "GoalStatus.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from GoalStatus.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit GoalStatus.idl instead.
*
*/
public class GoalStatusPubSubType : Halodi.CDR.TopicDataType<action_msgs.msg.GoalStatus>
{
   public override string Name => "action_msgs::msg::dds_::GoalStatus_";


   
   public override void serialize(action_msgs.msg.GoalStatus data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, action_msgs.msg.GoalStatus data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(action_msgs.msg.GoalStatus data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(action_msgs.msg.GoalStatus data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += action_msgs.msg.GoalInfoPubSubType.getCdrSerializedSize(data.goal_info, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(action_msgs.msg.GoalStatus data, Halodi.CDR.CDRSerializer cdr)
   {
      action_msgs.msg.GoalInfoPubSubType.write(data.goal_info, cdr);

      cdr.write_type_9(data.status);

   }

   public static void read(action_msgs.msg.GoalStatus data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.goal_info = action_msgs.msg.GoalInfoPubSubType.Create();
      action_msgs.msg.GoalInfoPubSubType.read(data.goal_info, cdr);
      	
      data.status=cdr.read_type_9();
      	

   }


    public static void Copy(action_msgs.msg.GoalStatus src, action_msgs.msg.GoalStatus target)
    {
        target.Set(src);
    }


}


}