using System.IO;
namespace lifecycle_msgs.msg
{

/**
* 
* Topic data type of the struct "TransitionEvent" defined in "TransitionEvent.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from TransitionEvent.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit TransitionEvent.idl instead.
*
*/
public class TransitionEventPubSubType : Halodi.CDR.TopicDataType<lifecycle_msgs.msg.TransitionEvent>
{
   public override string Name => "lifecycle_msgs::msg::dds_::TransitionEvent_";


   
   public override void serialize(lifecycle_msgs.msg.TransitionEvent data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, lifecycle_msgs.msg.TransitionEvent data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(lifecycle_msgs.msg.TransitionEvent data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(lifecycle_msgs.msg.TransitionEvent data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += lifecycle_msgs.msg.TransitionPubSubType.getCdrSerializedSize(data.transition, current_alignment);

      current_alignment += lifecycle_msgs.msg.StatePubSubType.getCdrSerializedSize(data.start_state, current_alignment);

      current_alignment += lifecycle_msgs.msg.StatePubSubType.getCdrSerializedSize(data.goal_state, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(lifecycle_msgs.msg.TransitionEvent data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_12(data.timestamp);

      lifecycle_msgs.msg.TransitionPubSubType.write(data.transition, cdr);

      lifecycle_msgs.msg.StatePubSubType.write(data.start_state, cdr);

      lifecycle_msgs.msg.StatePubSubType.write(data.goal_state, cdr);

   }

   public static void read(lifecycle_msgs.msg.TransitionEvent data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.timestamp=cdr.read_type_12();
      	
      data.transition = lifecycle_msgs.msg.TransitionPubSubType.Create();
      lifecycle_msgs.msg.TransitionPubSubType.read(data.transition, cdr);
      	
      data.start_state = lifecycle_msgs.msg.StatePubSubType.Create();
      lifecycle_msgs.msg.StatePubSubType.read(data.start_state, cdr);
      	
      data.goal_state = lifecycle_msgs.msg.StatePubSubType.Create();
      lifecycle_msgs.msg.StatePubSubType.read(data.goal_state, cdr);
      	

   }


    public static void Copy(lifecycle_msgs.msg.TransitionEvent src, lifecycle_msgs.msg.TransitionEvent target)
    {
        target.Set(src);
    }


}


}