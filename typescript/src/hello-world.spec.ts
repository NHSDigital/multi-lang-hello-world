import { helloWorld } from "./hello-world";

describe("helloworld", () => {
  describe("helloworld", () => {
    it("hello world says hello", () => {
      const actualResult = helloWorld();
      expect(helloWorld()).toEqual("hello world");
    });
  });
});
