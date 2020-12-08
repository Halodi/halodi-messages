using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "CameraInfo" defined in "CameraInfo.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from CameraInfo.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit CameraInfo.idl instead.
*
*/
public class CameraInfoPubSubType : Halodi.CDR.TopicDataType<CameraInfo>
{
   public override string Name => "sensor_msgs::msg::dds_::CameraInfo_";


   
   public override void serialize(sensor_msgs.msg.CameraInfo data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.CameraInfo data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.CameraInfo data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.CameraInfo data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.distortion_model.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.d.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += ((9) * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);
      current_alignment += ((9) * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);
      current_alignment += ((12) * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);
      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += sensor_msgs.msg.RegionOfInterestPubSubType.getCdrSerializedSize(data.roi, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.CameraInfo data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_4(data.height);

      cdr.write_type_4(data.width);

      cdr.write_type_d(data.distortion_model);

      	if(data.d == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int d_length = data.d.Count;
            cdr.write_type_2(d_length);
            for (int i0 = 0; i0 < d_length; i0++)
            {
      			cdr.write_type_6(data.d[i0]);
            }
        }
      for(int i0 = 0; i0 < 9; ++i0)
      {
        	cdr.write_type_6(data.k[i0]);	
      }

      for(int i0 = 0; i0 < 9; ++i0)
      {
        	cdr.write_type_6(data.r[i0]);	
      }

      for(int i0 = 0; i0 < 12; ++i0)
      {
        	cdr.write_type_6(data.p[i0]);	
      }

      cdr.write_type_4(data.binning_x);

      cdr.write_type_4(data.binning_y);

      sensor_msgs.msg.RegionOfInterestPubSubType.write(data.roi, cdr);

   }

   public static void read(sensor_msgs.msg.CameraInfo data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.height=cdr.read_type_4();
      	
      data.width=cdr.read_type_4();
      	
      data.distortion_model = cdr.read_type_d();	

      int d_length = cdr.read_type_2();
      data.d = new System.Collections.Generic.List<double>(d_length);
      for(int i = 0; i < d_length; i++)
      {
      	data.d.Add(cdr.read_type_6());
      	
      	
      }

      	
      for(int i0 = 0; i0 < 9; ++i0)
      {
        	data.k[i0] = cdr.read_type_6();
        	
      }
      	
      for(int i0 = 0; i0 < 9; ++i0)
      {
        	data.r[i0] = cdr.read_type_6();
        	
      }
      	
      for(int i0 = 0; i0 < 12; ++i0)
      {
        	data.p[i0] = cdr.read_type_6();
        	
      }
      	
      data.binning_x=cdr.read_type_4();
      	
      data.binning_y=cdr.read_type_4();
      	
      data.roi = sensor_msgs.msg.RegionOfInterestPubSubType.Create();
      sensor_msgs.msg.RegionOfInterestPubSubType.read(data.roi, cdr);
      	

   }


    public static void Copy(sensor_msgs.msg.CameraInfo src, sensor_msgs.msg.CameraInfo target)
    {
        target.Set(src);
    }


}


}