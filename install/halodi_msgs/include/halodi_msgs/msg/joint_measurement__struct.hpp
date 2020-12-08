// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/JointMeasurement.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__JOINT_MEASUREMENT__STRUCT_HPP_
#define HALODI_MSGS__MSG__JOINT_MEASUREMENT__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'joint'
#include "halodi_msgs/msg/joint_name__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__JointMeasurement __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__JointMeasurement __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct JointMeasurement_
{
  using Type = JointMeasurement_<ContainerAllocator>;

  explicit JointMeasurement_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : joint(_init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->position = 0.0;
      this->velocity = 0.0;
      this->measuredEffort = 0.0;
      this->desiredEffort = 0.0;
    }
  }

  explicit JointMeasurement_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : joint(_alloc, _init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->position = 0.0;
      this->velocity = 0.0;
      this->measuredEffort = 0.0;
      this->desiredEffort = 0.0;
    }
  }

  // field types and members
  using _joint_type =
    halodi_msgs::msg::JointName_<ContainerAllocator>;
  _joint_type joint;
  using _position_type =
    double;
  _position_type position;
  using _velocity_type =
    double;
  _velocity_type velocity;
  using _measuredEffort_type =
    double;
  _measuredEffort_type measuredEffort;
  using _desiredEffort_type =
    double;
  _desiredEffort_type desiredEffort;

  // setters for named parameter idiom
  Type & set__joint(
    const halodi_msgs::msg::JointName_<ContainerAllocator> & _arg)
  {
    this->joint = _arg;
    return *this;
  }
  Type & set__position(
    const double & _arg)
  {
    this->position = _arg;
    return *this;
  }
  Type & set__velocity(
    const double & _arg)
  {
    this->velocity = _arg;
    return *this;
  }
  Type & set__measuredEffort(
    const double & _arg)
  {
    this->measuredEffort = _arg;
    return *this;
  }
  Type & set__desiredEffort(
    const double & _arg)
  {
    this->desiredEffort = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::JointMeasurement_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::JointMeasurement_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::JointMeasurement_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::JointMeasurement_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::JointMeasurement_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::JointMeasurement_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::JointMeasurement_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::JointMeasurement_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::JointMeasurement_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::JointMeasurement_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__JointMeasurement
    std::shared_ptr<halodi_msgs::msg::JointMeasurement_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__JointMeasurement
    std::shared_ptr<halodi_msgs::msg::JointMeasurement_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const JointMeasurement_ & other) const
  {
    if (this->joint != other.joint) {
      return false;
    }
    if (this->position != other.position) {
      return false;
    }
    if (this->velocity != other.velocity) {
      return false;
    }
    if (this->measuredEffort != other.measuredEffort) {
      return false;
    }
    if (this->desiredEffort != other.desiredEffort) {
      return false;
    }
    return true;
  }
  bool operator!=(const JointMeasurement_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct JointMeasurement_

// alias to use template instance with default allocator
using JointMeasurement =
  halodi_msgs::msg::JointMeasurement_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__JOINT_MEASUREMENT__STRUCT_HPP_
