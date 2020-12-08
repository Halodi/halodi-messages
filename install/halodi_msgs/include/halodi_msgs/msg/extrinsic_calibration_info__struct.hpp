// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/ExtrinsicCalibrationInfo.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__EXTRINSIC_CALIBRATION_INFO__STRUCT_HPP_
#define HALODI_MSGS__MSG__EXTRINSIC_CALIBRATION_INFO__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'sensor_transforms'
// Member 'link_infos'
#include "geometry_msgs/msg/transform_stamped__struct.hpp"
// Member 'joint_infos'
#include "halodi_msgs/msg/robot_joint_calibration_info__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__ExtrinsicCalibrationInfo __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__ExtrinsicCalibrationInfo __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct ExtrinsicCalibrationInfo_
{
  using Type = ExtrinsicCalibrationInfo_<ContainerAllocator>;

  explicit ExtrinsicCalibrationInfo_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_init;
  }

  explicit ExtrinsicCalibrationInfo_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_init;
    (void)_alloc;
  }

  // field types and members
  using _sensor_transforms_type =
    rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::TransformStamped_<ContainerAllocator>, 255, typename ContainerAllocator::template rebind<geometry_msgs::msg::TransformStamped_<ContainerAllocator>>::other>;
  _sensor_transforms_type sensor_transforms;
  using _link_infos_type =
    rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::TransformStamped_<ContainerAllocator>, 255, typename ContainerAllocator::template rebind<geometry_msgs::msg::TransformStamped_<ContainerAllocator>>::other>;
  _link_infos_type link_infos;
  using _joint_infos_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator>, 255, typename ContainerAllocator::template rebind<halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator>>::other>;
  _joint_infos_type joint_infos;

  // setters for named parameter idiom
  Type & set__sensor_transforms(
    const rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::TransformStamped_<ContainerAllocator>, 255, typename ContainerAllocator::template rebind<geometry_msgs::msg::TransformStamped_<ContainerAllocator>>::other> & _arg)
  {
    this->sensor_transforms = _arg;
    return *this;
  }
  Type & set__link_infos(
    const rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::TransformStamped_<ContainerAllocator>, 255, typename ContainerAllocator::template rebind<geometry_msgs::msg::TransformStamped_<ContainerAllocator>>::other> & _arg)
  {
    this->link_infos = _arg;
    return *this;
  }
  Type & set__joint_infos(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator>, 255, typename ContainerAllocator::template rebind<halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator>>::other> & _arg)
  {
    this->joint_infos = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::ExtrinsicCalibrationInfo_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::ExtrinsicCalibrationInfo_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::ExtrinsicCalibrationInfo_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::ExtrinsicCalibrationInfo_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ExtrinsicCalibrationInfo_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ExtrinsicCalibrationInfo_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ExtrinsicCalibrationInfo_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ExtrinsicCalibrationInfo_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::ExtrinsicCalibrationInfo_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::ExtrinsicCalibrationInfo_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__ExtrinsicCalibrationInfo
    std::shared_ptr<halodi_msgs::msg::ExtrinsicCalibrationInfo_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__ExtrinsicCalibrationInfo
    std::shared_ptr<halodi_msgs::msg::ExtrinsicCalibrationInfo_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const ExtrinsicCalibrationInfo_ & other) const
  {
    if (this->sensor_transforms != other.sensor_transforms) {
      return false;
    }
    if (this->link_infos != other.link_infos) {
      return false;
    }
    if (this->joint_infos != other.joint_infos) {
      return false;
    }
    return true;
  }
  bool operator!=(const ExtrinsicCalibrationInfo_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct ExtrinsicCalibrationInfo_

// alias to use template instance with default allocator
using ExtrinsicCalibrationInfo =
  halodi_msgs::msg::ExtrinsicCalibrationInfo_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__EXTRINSIC_CALIBRATION_INFO__STRUCT_HPP_
