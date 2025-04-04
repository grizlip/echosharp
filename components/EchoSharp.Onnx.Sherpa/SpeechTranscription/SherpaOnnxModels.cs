// Licensed under the MIT license: https://opensource.org/licenses/MIT

using EchoSharp.Provisioning;
using SherpaOnnx;

namespace EchoSharp.Onnx.Sherpa.SpeechTranscription;

public static class SherpaOnnxModels
{
    public static readonly SherpaOnnxModel ZipFormerGigaSpeech = new SherpaOnnxOfflineModel(
        "sherpa-onnx-zipformer-gigaspeech-2023-12-12",
        new("https://github.com/k2-fsa/sherpa-onnx/releases/download/asr-models/sherpa-onnx-zipformer-gigaspeech-2023-12-12.tar.bz2"),
        ProvisioningModel.ArchiveTypes.TarGz,
        "rfO+bvOvWxNz+uzkrrp8MKbA6/UaqCFa0RYNTmpRTHW80CXK/YMupE6iu1sB/c523qlD1pYw2yUKy4voL4L54Q==",
        "4Y9U5HTgtUgx3IaPFSycEB+biwokWPAAeaYikqffZTQ92k8Bvma2ux9ddWXT7H6GtHrdrZGOGKzMd/c51IY6Iw==",
        307011274L,
        260990607L,
        (string path, ref OfflineModelConfig config) =>
    {
        config.Transducer.Encoder = Path.Combine(path, "encoder-epoch-30-avg-1.onnx");
        config.Transducer.Decoder = Path.Combine(path, "decoder-epoch-30-avg-1.onnx");
        config.Transducer.Joiner = Path.Combine(path, "joiner-epoch-30-avg-1.onnx");
        config.Tokens = Path.Combine(path, "tokens.txt");
    });

    public static readonly SherpaOnnxModel ZipFormerGigaSpeechInt8 = new SherpaOnnxOfflineModel(
        "sherpa-onnx-zipformer-gigaspeech-2023-12-12",
        new("https://github.com/k2-fsa/sherpa-onnx/releases/download/asr-models/sherpa-onnx-zipformer-gigaspeech-2023-12-12.tar.bz2"),
        ProvisioningModel.ArchiveTypes.TarGz,
        "rfO+bvOvWxNz+uzkrrp8MKbA6/UaqCFa0RYNTmpRTHW80CXK/YMupE6iu1sB/c523qlD1pYw2yUKy4voL4L54Q==",
        "4Y9U5HTgtUgx3IaPFSycEB+biwokWPAAeaYikqffZTQ92k8Bvma2ux9ddWXT7H6GtHrdrZGOGKzMd/c51IY6Iw==",
        307011274L,
        260990607L,
        (string path, ref OfflineModelConfig config) =>
    {
        config.Transducer.Encoder = Path.Combine(path, "encoder-epoch-30-avg-1.int8.onnx");
        config.Transducer.Decoder = Path.Combine(path, "decoder-epoch-30-avg-1.int8.onnx");
        config.Transducer.Joiner = Path.Combine(path, "joiner-epoch-30-avg-1.int8.onnx");
        config.Tokens = Path.Combine(path, "tokens.txt");
    });

    // TODO: Add more Sherpa Models (blocked because the models archive is always changing and breaking the ArchiveHash)
}
