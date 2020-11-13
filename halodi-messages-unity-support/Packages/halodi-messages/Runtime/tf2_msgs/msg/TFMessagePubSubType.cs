using System.IO;
namespace tf2_msgs.msg
{

/**
* 
* Topic data type of the struct "TFMessage" defined in "TFMessage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from TFMessage.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit TFMessage.idl instead.
*
*/
public class TFMessagePubSubType : Halodi.CDR.TopicDataType<TFMessage>
{
   public override string Name => "tf2_msgs::msg::dds_::TFMessage_";


   
   public override void serialize(tf2_msgs.msg.TFMessage data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, tf2_msgs.msg.TFMessage data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(tf2_msgs.msg.TFMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(tf2_msgs.msg.TFMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.transforms.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.TransformStampedPubSubType.getCdrSerializedSize(data.transforms[i0], current_alignment);}

      return current_alignment - initial_alignment;
   }

   public static void write(tf2_msgs.msg.TFMessage data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.transforms == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int transforms_length = data.transforms.Count;
            cdr.write_type_2(transforms_length);
            for (int i0 = 0; i0 < transforms_length; i0++)
            {
      			geometry_msgs.msg.TransformStampedPubSubType.write(data.transforms[i0], cdr);	      }
        }   }

   public static void read(tf2_msgs.msg.TFMessage data, Halodi.CDR.CDRDeserializer cdr)
   {

      int transforms_length = cdr.read_type_2();
      data.transforms = new System.Collections.Generic.List<geometry_msgs.msg.TransformStamped>(transforms_length);
      for(int i = 0; i < transforms_length; i++)
      {
      	geometry_msgs.msg.TransformStamped new_transforms = geometry_msgs.msg.TransformStampedPubSubType.Create(); 
      	geometry_msgs.msg.TransformStampedPubSubType.read(new_transforms, cdr);
      	data.transforms.Add(new_transforms);	
      	
      }

      	

   }


    public static void Copy(tf2_msgs.msg.TFMessage src, tf2_msgs.msg.TFMessage target)
    {
        target.Set(src);
    }


}


}