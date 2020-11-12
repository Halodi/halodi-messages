using System.IO;
namespace action_msgs.msg
{

/**
* 
* Topic data type of the struct "GoalInfo" defined in "GoalInfo.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from GoalInfo.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit GoalInfo.idl instead.
*
*/
public class GoalInfoPubSubType : Halodi.CDR.TopicDataType<action_msgs.msg.GoalInfo>
{
   public override string Name => "action_msgs::msg::dds_::GoalInfo_";


   
   public override void serialize(action_msgs.msg.GoalInfo data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, action_msgs.msg.GoalInfo data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(action_msgs.msg.GoalInfo data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(action_msgs.msg.GoalInfo data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += unique_identifier_msgs.msg.UUIDPubSubType.getCdrSerializedSize(data.goal_id, current_alignment);

      current_alignment += builtin_interfaces.msg.TimePubSubType.getCdrSerializedSize(data.stamp, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(action_msgs.msg.GoalInfo data, Halodi.CDR.CDRSerializer cdr)
   {
      unique_identifier_msgs.msg.UUIDPubSubType.write(data.goal_id, cdr);

      builtin_interfaces.msg.TimePubSubType.write(data.stamp, cdr);

   }

   public static void read(action_msgs.msg.GoalInfo data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.goal_id = unique_identifier_msgs.msg.UUIDPubSubType.Create();
      unique_identifier_msgs.msg.UUIDPubSubType.read(data.goal_id, cdr);
      	
      data.stamp = builtin_interfaces.msg.TimePubSubType.Create();
      builtin_interfaces.msg.TimePubSubType.read(data.stamp, cdr);
      	

   }


    public static void Copy(action_msgs.msg.GoalInfo src, action_msgs.msg.GoalInfo target)
    {
        target.Set(src);
    }


}


}