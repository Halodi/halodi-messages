using System.IO;
namespace stereo_msgs.msg
{

/**
* 
* Topic data type of the struct "DisparityImage" defined in "DisparityImage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from DisparityImage.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit DisparityImage.idl instead.
*
*/
public class DisparityImagePubSubType : Halodi.CDR.TopicDataType<stereo_msgs.msg.DisparityImage>
{
   public override string Name => "stereo_msgs::msg::dds_::DisparityImage_";


   
   public override void serialize(stereo_msgs.msg.DisparityImage data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, stereo_msgs.msg.DisparityImage data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(stereo_msgs.msg.DisparityImage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(stereo_msgs.msg.DisparityImage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += sensor_msgs.msg.ImagePubSubType.getCdrSerializedSize(data.image, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += sensor_msgs.msg.RegionOfInterestPubSubType.getCdrSerializedSize(data.valid_window, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(stereo_msgs.msg.DisparityImage data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      sensor_msgs.msg.ImagePubSubType.write(data.image, cdr);

      cdr.write_type_5(data.f);

      cdr.write_type_5(data.t);

      sensor_msgs.msg.RegionOfInterestPubSubType.write(data.valid_window, cdr);

      cdr.write_type_5(data.min_disparity);

      cdr.write_type_5(data.max_disparity);

      cdr.write_type_5(data.delta_d);

   }

   public static void read(stereo_msgs.msg.DisparityImage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.image = sensor_msgs.msg.ImagePubSubType.Create();
      sensor_msgs.msg.ImagePubSubType.read(data.image, cdr);
      	
      data.f=cdr.read_type_5();
      	
      data.t=cdr.read_type_5();
      	
      data.valid_window = sensor_msgs.msg.RegionOfInterestPubSubType.Create();
      sensor_msgs.msg.RegionOfInterestPubSubType.read(data.valid_window, cdr);
      	
      data.min_disparity=cdr.read_type_5();
      	
      data.max_disparity=cdr.read_type_5();
      	
      data.delta_d=cdr.read_type_5();
      	

   }


    public static void Copy(stereo_msgs.msg.DisparityImage src, stereo_msgs.msg.DisparityImage target)
    {
        target.Set(src);
    }


}


}